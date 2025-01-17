// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 01-01-2023
//
// Last Modified By : David McCarter
// Last Modified On : 09-28-2023
// ***********************************************************************
// <copyright file="ConcurrentHashSet.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Represents a thread-safe hash-based unique collection.</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe hash-based unique collection.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
public sealed class ConcurrentHashSet<T> : IReadOnlyCollection<T>, ICollection<T>
{

	/// <summary>
	/// The default capacity.
	/// </summary>
	private const int DefaultCapacity = 31;

	/// <summary>
	/// The maximum lock number.
	/// </summary>
	private const int MaxLockNumber = 1024;

	/// <summary>
	/// The budget.
	/// </summary>
	private int _budget;

	/// <summary>
	/// The comparer.
	/// </summary>
	private readonly IEqualityComparer<T> _comparer;

	/// <summary>
	/// The grow lock array.
	/// </summary>
	private readonly bool _growLockArray;

	/// <summary>
	/// The tables.
	/// </summary>
	private volatile Tables _tables;

	/// <summary>
	/// Prevents a default instance of the <see cref="ConcurrentHashSet{T}" /> class from being created.
	/// </summary>
	/// <param name="concurrencyLevel">The concurrency level. Must be a value of 1 or greater.</param>
	/// <param name="capacity">The capacity. Must be a value of 0 or greater.</param>
	/// <param name="growLockArray">if set to <c>true</c> [grow lock array].</param>
	/// <param name="comparer">The comparer.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	private ConcurrentHashSet(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<T> comparer)
	{
		if (concurrencyLevel < 1)
		{
			concurrencyLevel = 1;
		}

		concurrencyLevel = concurrencyLevel.EnsureMinimum(1);
		capacity = capacity.EnsureMinimum(0);

		// The capacity should be at least as large as the concurrency level. Otherwise, we would have locks that don't guard
		// any buckets.
		if (capacity < concurrencyLevel)
		{
			capacity = concurrencyLevel;
		}

		var locks = new object[concurrencyLevel];

		for (var lockCount = 0; lockCount < locks.Length; lockCount++)
		{
			locks[lockCount] = new object();
		}

		var countPerLock = new int[locks.Length];
		var buckets = new Node[capacity];

		this._tables = new Tables(buckets, locks, countPerLock);

		this._growLockArray = growLockArray;
		this._budget = buckets.Length / locks.Length;
		this._comparer = comparer ?? EqualityComparer<T>.Default;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet()
		: this(DefaultConcurrencyLevel, DefaultCapacity, true, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection<see cref="IEnumerable{T}" />.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet([NotNull] IEnumerable<T> collection)
		: this(collection, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	/// <param name="comparer">The comparer<see cref="IEqualityComparer{T}" />.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet([NotNull] IEqualityComparer<T> comparer)
		: this(concurrencyLevel: DefaultConcurrencyLevel, capacity: DefaultCapacity, growLockArray: true, comparer: comparer)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	/// <param name="concurrencyLevel">The concurrency level.</param>
	/// <param name="capacity">The initial capacity for the collection.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, int capacity)
		: this(concurrencyLevel, capacity, false, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection to pre load items.</param>
	/// <param name="comparer">The comparer.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet([NotNull] IEnumerable<T> collection, [NotNull] IEqualityComparer<T> comparer)
		: this(comparer) => this.InitializeFromCollection(collection);

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	/// <param name="concurrencyLevel">The concurrencyLevel<see cref="int" />.</param>
	/// <param name="collection">The collection<see cref="IEnumerable{T}" />.</param>
	/// <param name="comparer">The comparer<see cref="IEqualityComparer{T}" />.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, [NotNull] IEnumerable<T> collection, [NotNull] IEqualityComparer<T> comparer)
		: this(concurrencyLevel, DefaultCapacity, false, comparer) => this.InitializeFromCollection(collection);

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
	/// </summary>
	/// <param name="concurrencyLevel">The concurrencyLevel<see cref="int" />.</param>
	/// <param name="capacity">The capacity<see cref="int" />.</param>
	/// <param name="comparer">The comparer<see cref="IEqualityComparer{T}" />.</param>
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, int capacity, [NotNull] IEqualityComparer<T> comparer)
		: this(concurrencyLevel, capacity, false, comparer)
	{
	}

	/// <summary>
	/// Adds an item to the <see cref="ICollection">.</see>.
	/// </summary>
	/// <param name="item">The object to add to the <see cref="ICollection"></see>.</param>
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	void ICollection<T>.Add([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		_ = this.Add(item);
	}

	/// <summary>
	/// Copies the elements of the <see cref="ICollection"></see> to an <see cref="Array"></see>, starting at a particular <see cref="Array"></see> index.
	/// </summary>
	/// <param name="array">The one-dimensional <see cref="Array"></see> that is the destination of the elements copied from <see cref="ICollection"></see>. The <see cref="Array"></see> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
	/// <exception cref="ArgumentException">The index is equal to or greater than the length of the array, or the number of elements in the set is greater than the available space from index to the end of the destination array.</exception>
	/// <exception cref="ArgumentException">The index is equal to or greater than the length of the array, or the number of elements in the set is greater than the available space from index to the end of the destination array.</exception>
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	void ICollection<T>.CopyTo([NotNull] T[] array, int arrayIndex)
	{
		array = array.ArgumentItemsExists(nameof(array));

		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			var count = 0;

			for (var lockCount = 0; lockCount < this._tables._locks.Length && count >= 0; lockCount++)
			{
				count += this._tables._countPerLock[lockCount];
			}

			// "count" itself or "count + arrayIndex" can overflow
			if (array.Length - count < arrayIndex || count < 0)
			{
				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
			}

			this.CopyToItems(array, arrayIndex);
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Removes the first occurrence of a specific object from the <see cref="ICollection"></see>.
	/// </summary>
	/// <param name="item">The object to remove from the collection.</param>
	/// <returns>true if <paramref name="item">item</paramref> was successfully removed from the <see cref="ICollection"></see>; otherwise, false. This method also returns false if <paramref name="item">item</paramref> is not found in the original <see cref="ICollection"></see>.</returns>
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	bool ICollection<T>.Remove([NotNull] T item) => this.TryRemove(item);

	/// <summary>
	/// Gets a value indicating whether the <see cref="ICollection"></see> is read-only.
	/// </summary>
	/// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
	bool ICollection<T>.IsReadOnly => false;

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator" /> object that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator"></see> object that can be used to iterate through the collection.</returns>
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Acquires all locks.
	/// </summary>
	/// <param name="locksAcquired">The locks acquired.</param>
	private void AcquireAllLocks(ref int locksAcquired)
	{
		// First, acquire lock 0
		this.AcquireLocks(0, 1, ref locksAcquired);

		// Now that we have lock 0, the _locks array will not change (i.e., grow),
		// and so we can safely read _locks.Length.
		this.AcquireLocks(1, this._tables._locks.Length, ref locksAcquired);

		Debug.Assert(locksAcquired == this._tables._locks.Length);
	}

	/// <summary>
	/// Acquires the locks.
	/// </summary>
	/// <param name="fromInclusive">From inclusive.</param>
	/// <param name="toExclusive">To exclusive.</param>
	/// <param name="locksAcquired">The locks acquired.</param>
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
	{
		Debug.Assert(fromInclusive <= toExclusive);
		var locks = this._tables._locks;

		for (var inclusiveCount = fromInclusive; inclusiveCount < toExclusive; inclusiveCount++)
		{
			var lockTaken = false;

			try
			{
				Monitor.Enter(locks[inclusiveCount], ref lockTaken);
			}
			finally
			{
				if (lockTaken)
				{
					locksAcquired++;
				}
			}
		}
	}

	/// <summary>
	/// Adds item to the collection.
	/// </summary>
	/// <param name="item">The item.</param>
	/// <param name="hashCode">The hash code.</param>
	/// <param name="acquireLock">if set to <c>true</c> [acquire lock].</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	private bool AddInternal(T item, int hashCode, bool acquireLock)
	{
		while (true)
		{
			var tables = this._tables;

			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables._buckets.Length, tables._locks.Length);

			var resizeDesired = false;
			var lockTaken = false;

			try
			{
				if (acquireLock)
				{
					Monitor.Enter(tables._locks[lockNo], ref lockTaken);
				}

				// If the table just got resized, we may not be holding the right lock, and must retry.
				// This should be a rare occurrence.
				if (tables != this._tables)
				{
					continue;
				}

				// Try to find this item in the bucket
				Node previous = null;

				for (var current = tables._buckets[bucketNo]; current is not null; current = current._next)
				{
					Debug.Assert((previous is null && current == tables._buckets[bucketNo]) || previous._next == current);
					if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
					{
						return false;
					}

					previous = current;
				}

				// The item was not found in the bucket. Insert the new item.
				Volatile.Write(ref tables._buckets[bucketNo], new Node(item, hashCode, tables._buckets[bucketNo]));
				checked
				{
					tables._countPerLock[lockNo]++;
				}

				// If the number of elements guarded by this lock has exceeded the budget, resize the bucket table.
				// It is also possible that GrowTable will increase the budget but won't resize the bucket table.
				// That happens if the bucket table is found to be poorly utilized due to a bad hash function.
				if (tables._countPerLock[lockNo] > this._budget)
				{
					resizeDesired = true;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(tables._locks[lockNo]);
				}
			}

			// The fact that we got here means that we just performed an insertion. If necessary, we will grow the table.
			//
			// Concurrency notes:
			// - Notice that we are not holding any locks at when calling GrowTable. This is necessary to prevent deadlocks.
			// - As a result, it is possible that GrowTable will be called unnecessarily. But, GrowTable will obtain lock 0
			//   and then verify that the table we passed to it as the argument is still the current table.
			if (resizeDesired)
			{
				this.GrowTable(tables);
			}

			return true;
		}
	}

	/// <summary>
	/// Copies items.
	/// </summary>
	/// <param name="array">The array.</param>
	/// <param name="index">The index.</param>
	private void CopyToItems(T[] array, int index)
	{
		var buckets = this._tables._buckets;

		for (var bucketCount = 0; bucketCount < buckets.Length; bucketCount++)
		{
			for (var current = buckets[bucketCount]; current is not null; current = current._next)
			{
				array[index] = current._item;
				index++; // this should never flow, CopyToItems is only called when there's no overflow risk
			}
		}
	}

	/// <summary>
	/// Gets the bucket.
	/// </summary>
	/// <param name="hashCode">The hash code.</param>
	/// <param name="bucketCount">The bucket count.</param>
	/// <returns>System.Int32.</returns>
	private static int GetBucket(int hashCode, int bucketCount)
	{
		var bucketNo = (hashCode & 0x7fffffff) % bucketCount;
		Debug.Assert(bucketNo >= 0 && bucketNo < bucketCount);
		return bucketNo;
	}

	/// <summary>
	/// Gets the bucket and lock no.
	/// </summary>
	/// <param name="hashCode">The hash code.</param>
	/// <param name="bucketNo">The bucket no.</param>
	/// <param name="lockNo">The lock no.</param>
	/// <param name="bucketCount">The bucket count.</param>
	/// <param name="lockCount">The lock count.</param>
	private static void GetBucketAndLockNo(int hashCode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
	{
		bucketNo = (hashCode & 0x7fffffff) % bucketCount;
		lockNo = bucketNo % lockCount;

		Debug.Assert(bucketNo >= 0 && bucketNo < bucketCount);
		Debug.Assert(lockNo >= 0 && lockNo < lockCount);
	}

	/// <summary>
	/// Grows the table.
	/// </summary>
	/// <param name="tables">The tables.</param>
	private void GrowTable(Tables tables)
	{
		const int MaxArrayLength = 0X7FEFFFFF;
		var locksAcquired = 0;

		try
		{
			// The thread that first obtains _locks[0] will be the one doing the resize operation
			this.AcquireLocks(fromInclusive: 0, toExclusive: 1, locksAcquired: ref locksAcquired);

			// Make sure nobody resized the table while we were waiting for lock 0:
			if (tables != this._tables)
			{
				// We assume that since the table reference is different, it was already resized (or the budget
				// was adjusted). If we ever decide to do table shrinking, or replace the table for other reasons,
				// we will have to revisit this logic.
				return;
			}

			// Compute the (approx.) total size. Use an Int64 accumulation variable to avoid an overflow.
			long approxCount = 0;

			for (var tableCount = 0; tableCount < tables._countPerLock.Length; tableCount++)
			{
				approxCount += tables._countPerLock[tableCount];
			}

			// If the bucket array is too empty, double the budget instead of resizing the table
			if (approxCount < tables._buckets.Length / 4)
			{
				this._budget = 2 * this._budget;

				if (this._budget < 0)
				{
					this._budget = int.MaxValue;
				}

				return;
			}

			// Compute the new table size. We find the smallest integer larger than twice the previous table size, and not divisible by
			// 2,3,5 or 7. We can consider a different table-sizing policy in the future.
			var newLength = 0;
			var maximizeTableSize = false;
			try
			{
				checked
				{
					// Double the size of the buckets table and add one, so that we have an odd integer.
					newLength = (tables._buckets.Length * 2) + 1;

					// Now, we only need to check odd integers, and find the first that is not divisible
					// by 3, 5 or 7.
					while (newLength % 3 == 0 || newLength % 5 == 0 || newLength % 7 == 0)
					{
						newLength += 2;
					}

					Debug.Assert(newLength % 2 != 0);

					if (newLength > MaxArrayLength)
					{
						maximizeTableSize = true;
					}
				}
			}
			catch (OverflowException)
			{
				maximizeTableSize = true;
			}

			if (maximizeTableSize)
			{
				newLength = MaxArrayLength;

				// We want to make sure that GrowTable will not be called again, since table is at the maximum size.
				// To achieve that, we set the budget to int.MaxValue.
				//
				// (There is one special case that would allow GrowTable() to be called in the future:
				// calling Clear() on the ConcurrentHashSet will shrink the table and lower the budget.)
				this._budget = int.MaxValue;
			}

			// Now acquire all other locks for the table
			this.AcquireLocks(1, tables._locks.Length, ref locksAcquired);

			var newLocks = tables._locks;

			// Add more locks
			if (this._growLockArray && tables._locks.Length < MaxLockNumber)
			{
				newLocks = new object[tables._locks.Length * 2];
				Array.Copy(tables._locks, 0, newLocks, 0, tables._locks.Length);

				for (var tableCount = tables._locks.Length; tableCount < newLocks.Length; tableCount++)
				{
					newLocks[tableCount] = new object();
				}
			}

			var newBuckets = new Node[newLength];
			var newCountPerLock = new int[newLocks.Length];

			// Copy all data into a new table, creating new nodes for all elements
			for (var bucketCount = 0; bucketCount < tables._buckets.Length; bucketCount++)
			{
				var current = tables._buckets[bucketCount];

				while (current is not null)
				{
					var next = current._next;
					GetBucketAndLockNo(current._hashCode, out var newBucketNo, out var newLockNo, newBuckets.Length, newLocks.Length);

					newBuckets[newBucketNo] = new Node(current._item, current._hashCode, newBuckets[newBucketNo]);

					checked
					{
						newCountPerLock[newLockNo]++;
					}

					current = next;
				}
			}

			// Adjust the budget
			this._budget = Math.Max(1, newBuckets.Length / newLocks.Length);

			// Replace tables with the new versions
			this._tables = new Tables(newBuckets, newLocks, newCountPerLock);
		}
		finally
		{
			// Release all locks that we took earlier
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Initializes ConcurrentHashSet from a collection.
	/// </summary>
	/// <param name="collection">The collection.</param>
	private void InitializeFromCollection(IEnumerable<T> collection)
	{
		collection.ToList().ForEach(item => _ = this.AddInternal(item, this._comparer.GetHashCode(item), false));

		if (this._budget == 0)
		{
			this._budget = this._tables._buckets.Length / this._tables._locks.Length;
		}
	}

	/// <summary>
	/// Releases the locks.
	/// </summary>
	/// <param name="fromInclusive">From inclusive.</param>
	/// <param name="toExclusive">To exclusive.</param>
	private void ReleaseLocks(int fromInclusive, int toExclusive)
	{
		Debug.Assert(fromInclusive <= toExclusive);

		for (var inclusiveCount = fromInclusive; inclusiveCount < toExclusive; inclusiveCount++)
		{
			Monitor.Exit(this._tables._locks[inclusiveCount]);
		}
	}

	/// <summary>
	/// Adds the specified item to the <see cref="ConcurrentHashSet{T}" />.
	/// </summary>
	/// <param name="item">The item to add.</param>
	/// <returns>The <see cref="bool" />.</returns>
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public bool Add([NotNull] T item) => this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);

	/// <summary>
	/// Removes all items from the <see cref="ConcurrentHashSet{T}" />.
	/// </summary>
	[Information(nameof(Clear), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public void Clear()
	{
		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
			this._tables = newTables;
			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Determines whether the <see cref="ConcurrentHashSet{T}" /> contains the specified
	/// item.
	/// </summary>
	/// <param name="item">The item to locate in the <see cref="ConcurrentHashSet{T}" />.</param>
	/// <returns>true if the <see cref="ConcurrentHashSet{T}" /> contains the item; otherwise, false.</returns>
	[Information(nameof(Contains), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public bool Contains([NotNull] T item)
	{
		var hashCode = this._comparer.GetHashCode(item);

		// We must capture the _buckets field in a local variable. It is set to a new table on each table resize.
		var tables = this._tables;

		var bucketNo = GetBucket(hashCode, tables._buckets.Length);

		// We can get away w/out a lock here.
		// The Volatile.Read ensures that the load of the fields of 'n' doesn't move before the load from buckets[i].
		var current = Volatile.Read(ref tables._buckets[bucketNo]);

		while (current is not null)
		{
			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
			{
				return true;
			}

			current = current._next;
		}

		return false;
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ConcurrentHashSet{T}" />.
	/// </summary>
	/// <returns>An enumerator for the <see cref="ConcurrentHashSet{T}" />.</returns>
	[Information(nameof(GetEnumerator), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public IEnumerator<T> GetEnumerator()
	{
		var buckets = this._tables._buckets;

		for (var i = 0; i < buckets.Length; i++)
		{
			// The Volatile.Read ensures that the load of the fields of 'current' doesn't move before the load from buckets[i].
			var current = Volatile.Read(ref buckets[i]);

			while (current is not null)
			{
				yield return current._item;
				current = current._next;
			}
		}
	}

	/// <summary>
	/// Attempts to remove the item from the <see cref="ConcurrentHashSet{T}" />.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns>true if an item was removed successfully; otherwise, false.</returns>
	[Information(nameof(TryRemove), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public bool TryRemove([NotNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		var hashCode = this._comparer.GetHashCode(item);

		while (true)
		{
			var tables = this._tables;

			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables._buckets.Length, tables._locks.Length);

			lock (tables._locks[lockNo])
			{
				// If the table just got resized, we may not be holding the right lock, and must retry.
				// This should be a rare occurrence.
				if (tables != this._tables)
				{
					continue;
				}

				Node previous = null;
				for (var current = tables._buckets[bucketNo]; current is not null; current = current._next)
				{
					Debug.Assert((previous is null && current == tables._buckets[bucketNo]) || previous._next == current);

					if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
					{
						if (previous is null)
						{
							Volatile.Write(ref tables._buckets[bucketNo], current._next);
						}
						else
						{
							previous._next = current._next;
						}

						tables._countPerLock[lockNo]--;
						return true;
					}

					previous = current;
				}
			}

			return false;
		}
	}

	/// <summary>
	/// Gets the number of items contained in the <see cref="ConcurrentHashSet{T}" />...
	/// </summary>
	/// <value>The count.</value>
	[Information(nameof(Count), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public int Count
	{
		get
		{
			var count = 0;
			var acquiredLocks = 0;

			try
			{
				this.AcquireAllLocks(ref acquiredLocks);
				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
			}
			finally
			{
				this.ReleaseLocks(0, acquiredLocks);
			}

			return count;
		}
	}

	/// <summary>
	/// Gets the default concurrency level...
	/// </summary>
	/// <value>The default concurrency level.</value>
	public static int DefaultConcurrencyLevel => Environment.ProcessorCount;

	/// <summary>
	/// Gets a value indicating whether this instance is empty...
	/// </summary>
	/// <value><c>true</c> if this instance is empty; otherwise, <c>false</c>.</value>
	[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "7/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public bool IsEmpty
	{
		get
		{
			var acquiredLocks = 0;

			try
			{
				this.AcquireAllLocks(ref acquiredLocks);

				for (var counter = 0; counter < this._tables._countPerLock.Length; counter++)
				{
					if (this._tables._countPerLock[counter] != 0)
					{
						return false;
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, acquiredLocks);
			}

			return true;
		}
	}

	/// <summary>
	/// Class Node.
	/// </summary>
	private sealed class Node
	{

		/// <summary>
		/// The Hash Code...
		/// </summary>
		internal readonly int _hashCode;

		/// <summary>
		/// The item...
		/// </summary>
		internal readonly T _item;

		/// <summary>
		/// The next...
		/// </summary>
		internal volatile Node _next;

		/// <summary>
		/// Initializes a new instance of the <see cref="Node" /> class.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <param name="hashCode">The hash code.</param>
		/// <param name="next">The next.</param>
		internal Node(T item, int hashCode, Node next)
		{
			this._item = item;
			this._hashCode = hashCode;
			this._next = next;
		}

	}

	/// <summary>
	/// Class Tables.
	/// </summary>
	private sealed class Tables
	{

		/// <summary>
		/// The buckets..
		/// </summary>
		internal readonly Node[] _buckets;

		/// <summary>
		/// The count per lock..
		/// </summary>
		internal volatile int[] _countPerLock;

		/// <summary>
		/// The locks..
		/// </summary>
		internal readonly object[] _locks;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tables" /> class.
		/// </summary>
		/// <param name="buckets">The buckets.</param>
		/// <param name="locks">The locks.</param>
		/// <param name="countPerLock">The count per lock.</param>
		internal Tables(Node[] buckets, object[] locks, int[] countPerLock)
		{
			this._buckets = buckets;
			this._locks = locks;
			this._countPerLock = countPerLock;
		}

	}

}
