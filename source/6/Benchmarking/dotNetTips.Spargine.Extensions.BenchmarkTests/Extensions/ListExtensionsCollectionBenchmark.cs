// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2023
// ***********************************************************************
// <copyright file="ListExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ListExtensionsCollectionBenchmark : SmallCollectionsBenchmark
{

	private List<PersonProper> _peopleRefList;

	private List<PersonProper> _peopleRefSubSet;

	[Benchmark(Description = nameof(ListExtensions.AreEqual))]
	public void AreEqualList()
	{
		var result = this._peopleRefList.IsEqualTo(this._peopleRefSubSet);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.AsSpan))]
	public void AsSpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsSpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
	public void ClearNulls()
	{
		var people = this._peopleRefList;
		people.Add(null);

		var result = people.ClearNulls();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.CopyToCollection))]
	public void CopyToList()
	{
		var result = this._peopleRefList.CopyToCollection();

		this.Consume(result);
	}

	[Benchmark(Description = "Count")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void CountCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastCount))]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void CountFastCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.FastCount());
	}

	[Benchmark(Description = "LongCount")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void CountLongCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.LongCount());
	}

	[Benchmark(Description = nameof(Enumerable.TryGetNonEnumeratedCount))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void CountTryGetNonEnumeratedCount()
	{
		var people = this._peopleRefList;

		_ = Enumerable.TryGetNonEnumeratedCount(people, out var count);

		this.Consume(count);
	}

	[Benchmark(Description = nameof(ListExtensions.DoesNotHaveItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void DoesNotHaveItemsTest()
	{
		var people = this._peopleRefList;

		this.Consume(people.DoesNotHaveItems());
	}

	[Benchmark(Description = nameof(ListExtensions.HasItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.HasItems());
	}

	[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.HasItems(5));
	}

	[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		var people = this._peopleRefList;

		this.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
	}

	[Benchmark(Description = "Index []")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Index()
	{

		var result = this._peopleRefList[RandomNumberGenerator.GetInt32(0, this.Count - 1)];

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IndexAtLooped))]
	public void IndexAtLooped()
	{
		var result = this._peopleRefList.IndexAtLooped(RandomNumberGenerator.GetInt32(0, this.Count - 1));

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRefSubSet = this.GetPersonProperRefList().TakeLast(10).Clone<IEnumerable<PersonProper>>().ToList();
		this._peopleRefList = this.GetPersonProperRefList();
	}

	[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
	public void ToObservableCollection()
	{
		var result = this._peopleRefList.ToObservableCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyCollection))]
	public void ToReadOnlyCollection()
	{
		var result = this._peopleRefList.ToReadOnlyCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyObservableCollection))]
	public void ToReadOnlyObservableCollection()
	{
		var result = this._peopleRefList.ToReadOnlyObservableCollection();

		this.Consume(result);
	}

}

/// <summary>
/// Class PersonProperComparer.
/// Implements the <see cref="IEqualityComparer{PersonProper}" />
/// </summary>
/// <seealso cref="IEqualityComparer{PersonProper}" />
public class PersonProperComparer : IEqualityComparer<PersonProper>
{

	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
	/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y) => x?.Id == y?.Id;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <param name="obj">The <see cref="object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public int GetHashCode([DisallowNull] PersonProper obj) => obj.ArgumentNotNull().Id.GetHashCode(StringComparison.Ordinal);

}
