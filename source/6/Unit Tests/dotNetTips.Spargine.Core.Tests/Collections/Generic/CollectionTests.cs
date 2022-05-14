﻿// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="CollectionTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class CollectionTests
	{

		[TestMethod]
		public void AddFirstTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var collection = Collection<PersonProper>.Create(people);
			var person = RandomData.GenerateRefPerson<PersonProper>();

			collection.AddFirst(person);

			Assert.IsTrue(collection.First() == person);
		}

		[TestMethod]
		public void AddIfNotExistsTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var collection = Collection<PersonProper>.Create(people);
			var person = RandomData.GenerateRefPerson<PersonProper>();

			_ = collection.AddIfNotExists(collection.First());

			Assert.IsTrue(collection.Count == 10);

			_ = collection.AddIfNotExists(person);

			Assert.IsTrue(collection.Count == 11);
		}

		[TestMethod]
		public void AddLastTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var collection = Collection<PersonProper>.Create(people);
			var person = RandomData.GenerateRefPerson<PersonProper>();

			collection.AddLast(person);

			Assert.IsTrue(collection.Last() == person);
		}

		[TestMethod]
		public void CreateTest()
		{
			var collection = Collection<PersonProper>.Create();

			Assert.IsNotNull(collection);
		}

		[TestMethod]
		public void CreateWithCollectionTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);

			var collection = Collection<PersonProper>.Create(people);

			Assert.IsNotNull(collection);

			Assert.IsTrue(collection.Count == 10);
		}

		[TestMethod]
		public void CreateWithCollectionUniqueTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);

			var collection = Collection<PersonProper>.Create(people, ensureUnique: Tristate.True);

			Assert.IsNotNull(collection);

			Assert.IsTrue(collection.Count == 10);
		}

		[TestMethod]
		public void CreateWithCountTest()
		{
			var collection = Collection<PersonProper>.Create(10);

			Assert.IsNotNull(collection);
		}
	}
}