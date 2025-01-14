// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="TypeExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Xml.Serialization;
using DotNetTips.Spargine.Cache;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Defines test class TypeExtensionsTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class TypeExtensionsTests
{

	/// <summary>
	/// Defines the test method GetAbstractMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetAbstractMethodsTest()
	{
		var result = typeof(AbstractTestType).GetAllAbstractMethods();

		Assert.IsTrue(result.FastCount() == 1);

		result = typeof(DataTable).GetAllAbstractMethods();

		Assert.IsTrue(result.FastCount() == 0);
	}

	[TestMethod]
	public void GetAllDeclaredFieldsTest()
	{
		var result = typeof(PersonProper).GetAllDeclaredFields();

		Assert.IsTrue(result.FastCount() > 0);
	}

	[TestMethod]
	public void GetAllDeclaredMethodsTest()
	{
		var result = typeof(PersonProper).GetAllDeclaredMethods();

		Assert.IsTrue(result.FastCount() > 0);
	}

	/// <summary>
	/// Defines the test method GetAllFieldsTest.
	/// </summary>
	[TestMethod]
	public void GetAllFieldsTest()
	{
		var result1 = typeof(TestType).GetAllFields();

		Assert.IsTrue(result1.FastCount() == 1);

		var result2 = typeof(PersonProper).GetAllFields();

		Assert.IsTrue(result2.FastCount() >= 12);
	}

	/// <summary>
	/// Defines the test method GetAllMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetAllMethodsTest()
	{
		var result = typeof(TestType).GetAllMethods();

		Assert.IsTrue(result.FastCount() == 13);

		result = typeof(PersonProper).GetAllMethods();

		Assert.IsTrue(result.FastCount() >= 45);
	}

	/// <summary>
	/// Defines the test method GetAttributeFieldTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeFieldTest()
	{
		Assert.IsNotNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<DebuggerBrowsableAttribute>());

		Assert.IsNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<XmlIgnoreAttribute>());
	}

	/// <summary>
	/// Defines the test method GetAttributeMethodTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeMethodTest()
	{
		var method = typeof(TestType).GetAllMethods().FirstOrDefault(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0);

		var result1 = method.GetAttribute<CompilerGeneratedAttribute>();

		Assert.IsNotNull(result1);

		var result2 = method.GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the test method GetAttributePropertyTest.
	/// </summary>
	[TestMethod]
	public void GetAttributePropertyTest()
	{
		var property = typeof(TestType).GetAllProperties().FirstOrDefault();

		var result1 = property.GetAttribute<DebuggerBrowsableAttribute>();

		Assert.IsNotNull(result1);

		var result2 = property.GetAttribute<XmlAnyAttributeAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the test method GetAttributeTypeTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeTypeTest()
	{
		var result1 = typeof(TestType).GetAttribute<XmlRootAttribute>();

		Assert.IsNotNull(result1);

		var result2 = typeof(TestType).GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the test method GetGenericMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetGenericMethodsTest()
	{
		var result = typeof(TestType).GetAllGenericMethods();

		Assert.IsTrue(result.FastCount() == 1);
	}

	[TestMethod]
	public void GetImplementedInterfacesTest()
	{
		var table = new DataTable();

		var result = table.GetImplementedInterfaces("IComponent");

		Assert.IsTrue(result.FastCount() == 1);

		result = table.GetImplementedInterfaces("IFakeInterface");

		Assert.IsTrue(result.FastCount() == 0);

		result = table.GetImplementedInterfaces("IComponent", "IDisposable");

		Assert.IsTrue(result.FastCount() == 2);

	}

	[TestMethod]
	public void GetMaxTest()
	{
		var cord1 = RandomData.GenerateCoordinate<CoordinateProper>();
		var cord2 = RandomData.GenerateCoordinate<CoordinateProper>();

		var result = cord1.Max(cord2);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Defines the test method GetPropertiesTest.
	/// </summary>
	[TestMethod]
	public void GetPropertiesTest()
	{
		var result = typeof(PersonProper).GetAllProperties();

		Assert.IsTrue(result.FastCount() >= 10);
	}

	/// <summary>
	/// Defines the test method GetPublicMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetPublicMethodsTest()
	{
		var result = typeof(PersonProper).GetAllPublicMethods();

		Assert.IsTrue(result.FastCount() >= 30);
	}

	/// <summary>
	/// Defines the test method GetStaticMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetStaticMethodsTest()
	{
		var result = typeof(TestType).GetAllStaticMethods();

		Assert.IsTrue(result.FastCount() == 1);
	}

	/// <summary>
	/// Defines the test method GetTypeMembersWithGivenAttributeTest.
	/// </summary>
	[TestMethod]
	public void GetTypeMembersWithGivenAttributeTest()
	{
		var result1 = typeof(TestType).GetTypeMembersWithAttribute<XmlIgnoreAttribute>();

		Assert.IsTrue(result1.FastCount() == 1);

		var result2 = typeof(TestType).GetTypeMembersWithAttribute<XmlAnyAttributeAttribute>();

		Assert.IsTrue(result2.FastCount() == 0);
	}

	[TestMethod]
	public void GetTypeOfTypeTest()
	{
		var refPerson = new PersonProper();

		var result = refPerson.GetTypeOfType();

		Assert.IsTrue(result == TypeExtensions.TypeOfType.Reference);

		var valPerson = new Tester.Models.ValueTypes.Person();

		result = valPerson.GetTypeOfType();

		Assert.IsTrue(result == TypeExtensions.TypeOfType.Value);

		var recordPerson = new PersonRecord("dotnetdave@live.com", "100");

		result = recordPerson.GetTypeOfType();

		Assert.IsTrue(result == TypeExtensions.TypeOfType.Record);
	}

	[TestMethod]
	public void HasAttributeTest()
	{
#pragma warning disable SYSLIB0003 // Type or member is obsolete
		var result1 = typeof(PermissionSet).GetMethod("ConvertPermissionSet").HasAttribute<ObsoleteAttribute>();
#pragma warning restore SYSLIB0003 // Type or member is obsolete

		Assert.IsTrue(result1);

#pragma warning disable SYSLIB0003 // Type or member is obsolete
		var result2 = typeof(PermissionSet).GetMethod("ConvertPermissionSet").HasAttribute<XmlAnyAttributeAttribute>();
#pragma warning restore SYSLIB0003 // Type or member is obsolete

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void HasBaseClassTest()
	{
		var result1 = typeof(DataTable).HasBaseClass(typeof(MarshalByValueComponent));

		Assert.IsTrue(result1);

		var result2 = typeof(DataTable).HasBaseClass(typeof(ValueType));

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void HasParameterlessConstructorTest()
	{
		var result = typeof(PersonProper).HasParameterlessConstructor();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEnumerableTest()
	{
		var result1 = typeof(BitArray).IsEnumerable();

		Assert.IsTrue(result1);

		var result2 = typeof(DataTable).IsEnumerable();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsNullableTest()
	{
		var result1 = typeof(Foo).GetProperty("Bar").PropertyType.IsNullable();

		Assert.IsTrue(result1);

		var result2 = typeof(PersonProper).GetProperty("FirstName").PropertyType.IsNullable();

		Assert.IsFalse(result2);
	}

	/// <summary>
	/// Defines the test method IsNumericTest.
	/// </summary>
	[TestMethod]
	public void IsNumericTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();
		var person = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsTrue(people.GetType().IsEnumerable());
		Assert.IsFalse(person.GetType().IsEnumerable());
	}

	[TestMethod]
	public void IsStaticTest()
	{
		var result1 = typeof(InMemoryCache).GetProperty("Instance").IsStatic();
		Assert.IsTrue(result1);

		var result2 = typeof(PersonProper).GetProperty("FirstName").IsStatic();
		Assert.IsFalse(result2);
	}

}
