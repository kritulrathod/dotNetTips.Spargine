﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class CollectionExtensionsTests
    {
        [TestMethod]
        public void AddIfNotExistsComparerTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;
            var comparer = new PersonProperComparer();
            PersonProperComparer nullComparer = null;
            PersonCollection<PersonProper> nullList = null;

            // Test Parameters
            _ = Assert.ThrowsException<ArgumentReadOnlyException>(() => people.AsReadOnly().AddIfNotExists(person));
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(person, nullComparer));
            _ = Assert.ThrowsException<ArgumentNullException>(() => nullList.AddIfNotExists(RandomData.GeneratePerson<PersonProper>()));

            // TEST
            Assert.IsFalse(people.AddIfNotExists(nullPerson));


            Assert.IsTrue(people.AddIfNotExists(person));

            Assert.IsTrue(people.AddIfNotExists(RandomData.GeneratePerson<PersonProper>(), comparer));

        }

        [TestMethod]
        public void AddIfNotExistsMultipleItemTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(10);

            _ = people.AddIfNotExists(newPeople.ToArray());
            Assert.IsTrue(people.Count == 20);

            _ = people.AddIfNotExists(newPeople.ToArray());
            Assert.IsTrue(people.Count == 20);

            _ = people.AddIfNotExists();
            Assert.IsTrue(people.Count == 20);
        }

        [TestMethod]
        public void AddIfNotExistsSingleItemTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonProper nullPerson = null;

            // Test Parameters
            _ = Assert.ThrowsException<ArgumentReadOnlyException>(() => people.AsReadOnly().AddIfNotExists(RandomData.GeneratePerson<PersonProper>()));

            // TEST
            Assert.IsFalse(people.AddIfNotExists(nullPerson));

            var testPerson = RandomData.GeneratePerson<PersonProper>();

            Assert.IsTrue(people.AddIfNotExists(testPerson));

            Assert.IsFalse(people.AddIfNotExists(testPerson));
        }

        [TestMethod]
        public void AddRangeListTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

            people.AddRange(newPeople);

            Assert.IsTrue(people.Count == 12);

            _ = people.AddRange(newPeople, Tristate.UseDefault);

            Assert.IsTrue(people.Count == 12);
        }

        [TestMethod]
        public void DoesNotHaveItemsTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var emptyPeople = new PersonCollection<PersonProper>();

            Assert.IsFalse(people.DoesNotHaveItems());

            Assert.IsTrue(emptyPeople.DoesNotHaveItems());
        }

        [TestMethod]
        public void HasItemsTest()
        {
            var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

            Assert.IsTrue(collection.HasItems());

            Assert.IsTrue(collection.HasItems(10));

            Assert.IsTrue(collection.ToList().HasItems());

            Assert.IsTrue(collection.ToList().HasItems(10));
        }
    }

    public class PersonProperComparer : IEqualityComparer<PersonProper>
    {
        public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y) { return x.Id == y.Id; }

        public int GetHashCode([DisallowNull] PersonProper obj) { return obj.Id.GetHashCode(); }
    }
}