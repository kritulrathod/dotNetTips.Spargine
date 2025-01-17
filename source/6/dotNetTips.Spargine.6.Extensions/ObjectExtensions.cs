// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-10-2023
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class ObjectExtensions.
/// </summary>
public static class ObjectExtensions
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Tries to dispose items in the <see cref="IEnumerable" />.
	/// </summary>
	/// <param name="items">The items.</param>
	private static void DisposeCollection(this IEnumerable items) => ProcessCollectionToDispose(items);

	/// <summary>
	/// Processes the <see cref="IEnumerable" /> to dispose.
	/// </summary>
	/// <param name="items">The items.</param>
	private static void ProcessCollectionToDispose(IEnumerable items)
	{
		if (items.HasItems())
		{
			foreach (var item in items)
			{
				if (item is IDisposable disposeItem)
				{
					disposeItem.TryDispose();
				}
			}
		}
	}

	/// <summary>
	/// Converts object to a different type.
	/// Validates that <paramref name="obj" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="obj">The value.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
	[Information(nameof(As), UnitTestCoverage = 100, Status = Status.Available)]
	public static T As<T>([NotNull] this object obj) => (T)obj.ArgumentNotNull();

	/// <summary>
	/// Clones the specified object.
	/// Validates that <paramref name="obj" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="obj">The object.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
	[Information(nameof(Clone), UnitTestCoverage = 100, Status = Status.Available)]
	public static T Clone<T>([NotNull] this object obj) => FromJson<T>(obj.ArgumentNotNull().ToJson());

	/// <summary>
	/// Computes the sha256 hash for an object using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// Validates that <paramref name="obj" /> is not null.
	/// </summary>
	/// <param name="obj">The data.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ComputeSha256Hash), UnitTestCoverage = 100, Status = Status.Available)]
	public static string ComputeSha256Hash([NotNull] this object obj)
	{
		obj = obj.ArgumentNotNull();

		// Create a SHA256
		// ComputeHash - returns byte array
		var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(obj.ToJson()));

		// Convert byte array to a string
		var sb = _stringBuilderPool.Get();

		try
		{
			for (var byteIndex = 0; byteIndex < bytes.Length; byteIndex++)
			{
				_ = sb.Append(bytes[byteIndex].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Disposes the fields in the object.
	/// </summary>
	/// <param name="obj">The object.</param>
	[Information(nameof(DisposeFields), UnitTestCoverage = 100, Status = Status.Available)]
	public static void DisposeFields([NotNull] this IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		var list = obj.GetType().GetRuntimeFields().Where(p => p.IsStatic is false).ToList();

		if (list.DoesNotHaveItems())
		{
			return;
		}

		for (var fieldCount = 0; fieldCount < list.FastCount(); fieldCount++)
		{
			var value = list[fieldCount].GetValue(obj);

			if (value is not null)
			{
				if (value is IDisposable disposableItem)
				{
					disposableItem.TryDispose();
				}
				else if (value is IEnumerable collection)
				{
					collection.DisposeCollection();
				}
			}
		}
	}

	/// <summary>
	/// Deserializes the Json <see cref="string" />.
	/// Validates that <paramref name="json" /> is not null and contains text.
	/// </summary>
	/// <typeparam name="TResult">The type of the t result.</typeparam>
	/// <param name="json">The json.</param>
	/// <returns>TResult.</returns>
	[Information(nameof(FromJson), "David McCarter", "4/21/2022", UnitTestCoverage = 100, Status = Status.Available)]
	public static TResult FromJson<TResult>([NotNull] this string json) => JsonSerialization.Deserialize<TResult>(json.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Determines whether the specified object has the property.
	/// Validates that <paramref name="propertyName" /> is not null and contains text.
	/// </summary>
	/// <param name="obj">The instance.</param>
	/// <param name="propertyName">Name of the property.</param>
	/// <returns><c>true</c> if the specified property name has property; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Object name cannot be null.</exception>
	[Information(nameof(HasProperty), UnitTestCoverage = 100, Status = Status.Available)]
	public static bool HasProperty([NotNull] this object obj, string propertyName)
	{
		if (obj is null)
		{
			return false;
		}

		propertyName = propertyName.ArgumentNotNullOrEmpty();

		var propertyInfo = obj.GetType().GetRuntimeProperties().FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.Ordinal));

		return propertyInfo is not null;
	}

	/// <summary>
	/// Initializes the fields of an object.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
	[Information(nameof(InitializeFields), UnitTestCoverage = 100, Status = Status.Available)]
	public static void InitializeFields([NotNull] this object obj)
	{
		if (obj is null)
		{
			return;
		}

		var fieldInfos = obj.GetType().GetRuntimeFields().ToList();

		if (fieldInfos.DoesNotHaveItems())
		{
			return;
		}

		for (var fieldCount = 0; fieldCount < fieldInfos.FastCount(); fieldCount++)
		{
			var fieldInfo = fieldInfos[fieldCount];
			var objectValue = fieldInfo.GetValue(obj);
			var runtimeField = obj.GetType().GetRuntimeField(fieldInfo.Name);

			if (runtimeField is not null)
			{
				var t = Nullable.GetUnderlyingType(runtimeField.FieldType) ?? runtimeField.FieldType;
				var safeValue = (objectValue is null)
					? null
					: Convert.ChangeType(objectValue, t, CultureInfo.InvariantCulture);
				runtimeField.SetValue(obj, safeValue);
			}
		}
	}

	/// <summary>
	/// Determines whether object is not null.
	/// </summary>
	/// <param name="obj">The obj.</param>
	/// <returns><count>true</count> if [is not null] [the specified object]; otherwise, <count>false</count>.</returns>
	[Information(nameof(IsNotNull), UnitTestCoverage = 100, Status = Status.Available)]
	public static bool IsNotNull(this object obj) => obj is not null;

	/// <summary>
	/// Determines whether the specified object is null.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <returns><count>true</count> if the specified object is null; otherwise, <count>false</count>.</returns>
	[Information(nameof(IsNull), UnitTestCoverage = 100, Status = Status.Available)]
	public static bool IsNull(this object obj) => obj is null;

	/// <summary>
	/// Generates a Dictionary that represents the property name (Key) and it's value to a <see cref="IDictionary{TKey, TValue}" />.
	/// Validates that <paramref name="obj" /> is not null.
	/// </summary>
	/// <param name="obj">The input.</param>
	/// <param name="memberName">Name of the member used to identify the object.</param>
	/// <param name="ignoreNulls">if set to <c>true</c> [ignore <see langword="null" /> property values].</param>
	/// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
	/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
	/// <example>Output:
	/// [0]: {[PersonRecord.BornOn, 1/29/2007 11:52:12 AM -08:00]}
	/// [1]: {[PersonRecord.CellPhone, 747-388-4458]}
	/// [2]: {[PersonRecord.Email, elfhlsoepfmuiyr@uomrrywscvaapwjcu.org.uk]}
	/// [3]: {[PersonRecord.FirstName, ZyeMgwQRFABsisq]}
	/// [4]: {[PersonRecord.HomePhone, 255 - 871 - 4415]}
	/// [5]: {[PersonRecord.Id, 58dc933fe6004719a37e7a35373ad645]}
	/// [6]: {[PersonRecord.LastName, j_`iqWAGoOeKTpjWhojFyRHld]}
	/// [7]: {[PersonRecord.Addresses[0].Address1, XkbOcAlseMEMnPY ^ jkEcYWnFD]}
	/// [8]: {[PersonRecord.Addresses[0].Address2, tJkpTHikrRfFaGENX]`_agaw[]}
	/// [9]: {[PersonRecord.Addresses[0].City, KlWA ^ Aw]KhqADREV\uwmXJeAU]}
	/// [10]: {[PersonRecord.Addresses[0].Country, AtN`\NbnUIVSjUQicVXNMUL[J]}
	/// [11]: {[PersonRecord.Addresses[0].Id, 9330f3a225b14d96b67779f2c932302a]}
	/// [12]: {[PersonRecord.Addresses[0].CountyProvince, EkdKDBGWf ^ Givi[OMhIh]}
	/// [13]: {[PersonRecord.Addresses[0].State, RGOuDpJyfgwxyfC]}
	/// [14]: {[PersonRecord.Addresses[0].Phone, 065 - 507 - 7161]}
	/// [15]: {[PersonRecord.Addresses[0].PostalCode, 56633485]}
	/// [16]: {[PersonRecord.Addresses[1].Address1, lGSJwGNOtd ^ rXv`RxPcVCZHhk]}
	/// [17]: {[PersonRecord.Addresses[1].Address2, \EJGOmHyfAPERA ^ DrTR`xlDFU]}
	/// [18]: {[PersonRecord.Addresses[1].City, xiWPASydY[BEHfpVrluPNgOFS]}
	/// [19]: {[PersonRecord.Addresses[1].Country, JFpIljBDlQEkiehQ[r`\xjh[J]}
	/// [20]: {[PersonRecord.Addresses[1].Id, 8c95fd0cbbcf4beb993081bdd9c96ceb]}
	/// [21]: {[PersonRecord.Addresses[1].CountyProvince, FyHoHRZQwpMJ[gjABVUk]}
	/// [22]: {[PersonRecord.Addresses[1].State, dxeZkn[HyLo\wUS]}
	/// [23]: {[PersonRecord.Addresses[1].Phone, 511 - 286 - 7653]}
	/// [24]: {[PersonRecord.Addresses[1].PostalCode, 33385672]}
	/// </example>
	[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static IDictionary<string, string> PropertiesToDictionary([NotNull] this object obj, string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
	{
		var result = new Dictionary<string, string>();
		_ = memberName.ArgumentNotNull();

		var objectType = obj.ArgumentNotNull().GetType();

		// Reserve a special treatment for specific types by design (like string -that's a list of chars and you don't want to iterate on its items)
		if (TypeHelper.BuiltInTypeNames.ContainsKey(objectType))
		{
			result.Add(memberName, obj.ToString());
			return result;
		}

		// If the type implements the IEnumerable interface.
		if (objectType.IsEnumerable())
		{
			var itemCount = 0;

			// Loop through the collection using the enumerator strategy and collect all items in the result bag
			// Note: if the collection is empty it will not return anything about its existence,
			// because the method is supposed to catch value items not the list itself
			foreach (var item in (IEnumerable)obj)
			{
				var itemId = itemCount++;

				var itemInnerMember = string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", memberName, itemId);

				result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
			}

			return result;
		}

		// Otherwise go deeper in the object tree.
		// And foreach object public property collect each value
		var propertyCollection = objectType.GetProperties();

		var newMemberName = string.Empty;

		if (memberName.Length > 0)
		{
			newMemberName = $"{memberName}{ControlChars.Dot}";
		}

		for (var propertyIndex = 0; propertyIndex < propertyCollection.Length; propertyIndex++)
		{
			var property = propertyCollection[propertyIndex];
			var innerObject = property.GetValue(obj, null);

			if (ignoreNulls && innerObject is null)
			{
				continue;
			}

			var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);
			result = result.Concat(innerObject.PropertiesToDictionary(innerMember)).ToDictionary(e => e.Key, e => e.Value);
		}

		return result;
	}

	/// <summary>
	/// Generates a string that returns the property names and values.
	/// The input cannot be a collection type.
	/// Supports nested types.
	/// </summary>
	/// <param name="obj">The input.</param>
	/// <param name="header">The header.</param>
	/// <param name="keyValueSeparator">The key value separator.</param>
	/// <param name="sequenceSeparator">The delimiter.</param>
	/// <param name="ignoreNulls">if set to <c>true</c> [ignore null values].</param>
	/// <param name="includeMemberName">Name of the include member.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
	/// <exception cref="ArgumentInvalidException">Object cannot be a collection type.</exception>
	/// <example>Output:
	/// PersonRecord, PersonRecord.BornOn:1/29/2007 11:52:12 AM -08:00, PersonRecord.CellPhone:747-388-4458,
	/// PersonRecord.Email:elfhlsoepfmuiyr @uomrrywscvaapwjcu.org.uk, PersonRecord.FirstName:ZyeMgwQRFABsisq,
	/// PersonRecord.HomePhone:255-871-4415, PersonRecord.Id:58dc933fe6004719a37e7a35373ad645,
	/// PersonRecord.LastName:j_`iqWAGoOeKTpjWhojFyRHld, PersonRecord.Addresses[0].Address1:XkbOcAlseMEMnPY^jkEcYWnFD,
	/// PersonRecord.Addresses[0].Address2:tJkpTHikrRfFaGENX]`_agaw[,
	/// PersonRecord.Addresses[0].City:KlWA ^ Aw] KhqADREV\\uwmXJeAU,
	/// PersonRecord.Addresses[0].Country:AtN`\\NbnUIVSjUQicVXNMUL[J,
	/// PersonRecord.Addresses[0].Id:9330f3a225b14d96b67779f2c932302a,
	/// PersonRecord.Addresses[0].CountyProvince:EkdKDBGWf ^ Givi[OMhIh,
	/// PersonRecord.Addresses[0].State:RGOuDpJyfgwxyfC, PersonRecord.Addresses[0].Phone:065 - 507 - 7161,
	/// PersonRecord.Addresses[0].PostalCode:56633485, PersonRecord.Addresses[1].Address1:lGSJwGNOtd ^ rXv`RxPcVCZHhk,
	/// PersonRecord.Addresses[1].Address2:\\EJGOmHyfAPERA ^ DrTR`xlDFU,
	/// PersonRecord.Addresses[1].City:xiWPASydY[BEHfpVrluPNgOFS,
	/// PersonRecord.Addresses[1].Country:JFpIljBDlQEkiehQ[r`\\xjh[J,
	/// PersonRecord.Addresses[1].Id:8c95fd0cbbcf4beb993081bdd9c96ceb,
	/// PersonRecord.Addresses[1].CountyProvince:FyHoHRZQwpMJ[gjABVUk,
	/// PersonRecord.Addresses[1].State:dxeZkn[HyLo\\wUS, PersonRecord.Addresses[1].Phone:511 - 286 - 7653,
	/// PersonRecord.Addresses[1].PostalCode:33385672
	/// </example>
	[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb2021")]
	public static string PropertiesToString([NotNull] this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, [NotNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
	{
		if (obj is null)
		{
			return string.Empty;
		}

		var typeName = obj.GetType().Name;

		if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
		{
			typeName = "Item";
		}
		else if (includeMemberName is false)
		{
			typeName = string.Empty;
		}

		var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

		var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

		return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result.Remove(0, sequenceSeparator.Length) : result;
	}

	/// <summary>
	/// Returns ToString() value if not null.
	/// </summary>
	/// <param name="obj">The field.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(StripNull), UnitTestCoverage = 100, Status = Status.Available)]
	public static string StripNull(this object obj) => obj is null ? string.Empty : obj.ToString();

	/// <summary>
	/// Serializes object to Json.
	/// Validates that <paramref name="obj" /> is not null.
	/// </summary>
	/// <param name="obj">The instance.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToJson), UnitTestCoverage = 100, Status = Status.Available)]
	public static string ToJson([NotNull] this object obj) => JsonSerializer.Serialize(obj.ArgumentNotNull());

	/// <summary>
	/// Serializes object to Json.
	/// Validates that <paramref name="obj" /> is not null.
	/// </summary>
	/// <param name="obj">The instance.</param>
	/// <param name="options">The options.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToJson), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug23")]
	public static SimpleResult<string> ToJson([NotNull] this object obj, JsonSerializerOptions options = null)
	{
		obj = obj.ArgumentNotNull();

		try
		{
			return SimpleResult.FromValue(JsonSerializer.Serialize(obj, options));
		}
		catch (NotSupportedException ex)
		{
			return SimpleResult.FromException<string>(ex);
		}
	}

	/// <summary>
	/// Saves object to Json file.
	/// Validates that <paramref name="obj" /> and <paramref name="fileName" /> is not null.
	/// </summary>
	/// <param name="obj">The instance.</param>
	/// <param name="fileName">The file.</param>
	/// <exception cref="ArgumentNullException">obj</exception>
	/// <exception cref="ArgumentException">message - fileName</exception>
	[Information(nameof(ToJsonFile), UnitTestCoverage = 100, Status = Status.Available)]
	public static void ToJsonFile([NotNull] this object obj, string fileName)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();

		var json = JsonSerializer.Serialize(obj.ArgumentNotNull());

		File.WriteAllText(fileName, json, Encoding.UTF8);
	}

	/// <summary>
	/// Tries the to call Dispose on the object.
	/// </summary>
	/// <param name="obj">The obj.</param>
	[Information(nameof(TryDispose), UnitTestCoverage = 100, Status = Status.Available)]
	public static void TryDispose(this IDisposable obj) => TryDispose(obj, false);

	/// <summary>
	/// Tries to dispose the object. Supports <see cref="IDisposable" /> and <see cref="IAsyncDisposable" />.
	/// </summary>
	/// <param name="obj">The obj.</param>
	/// <param name="throwException">if set to <count>true</count> [throw exception].</param>
	/// <exception cref="ArgumentNullException">obj</exception>
	[Information(nameof(TryDispose), UnitTestCoverage = 100, Status = Status.Available)]
	public static void TryDispose([NotNull] this IDisposable obj, [DoesNotReturnIf(true)] bool throwException)
	{
		if (obj is null)
		{
			return;
		}

		try
		{
			if (obj is IAsyncDisposable asyncDisposable)
			{
				var result = asyncDisposable.DisposeAsync();

				if (result.IsFaulted)
				{
					ExceptionThrower.ThrowInvalidOperationException(Resources.ThereIsAnIssueDisposingOfTheObjectUsingAsyncDispose);
				}
			}
			else
			{
				obj.Dispose();
			}
		}
		catch
		{
			if (throwException)
			{
				throw;
			}
		}
	}

}
