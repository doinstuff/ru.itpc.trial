using System;
using NUnit.Framework;
using ru.itpc.trial.Models;
using ru.itpc.trial.Data;

namespace ru.itpc.trial.test.Models
{
    [TestFixture]
    public class PersonRecordTest
    {
        [Test]
        public void PersonRecord_construction_test()
        {
            string firstName = "Jack";
            string lastName = "Sparrow";

            PersonRecord person = new PersonRecord(firstName, lastName);

            /// Identified и Person должны быть интерфейсами
            Assert.IsInstanceOf(typeof(Identified<string>), person);
            Assert.IsInstanceOf(typeof(Person), person);

            Assert.NotNull(person.Id);
            Assert.IsInstanceOf(typeof(string), person.Id);
            Assert.AreNotEqual(Guid.Empty.ToString(), person.Id);

            Assert.AreEqual(firstName, person.FirstName);
            Assert.AreEqual(lastName, person.LastName);
            Assert.LessOrEqual(person.BirthDate, DateTime.Now);
        }
    }
}
