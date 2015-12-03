using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using ru.itpc.trial.Models;
using ru.itpc.trial.Data;

namespace ru.itpc.trial.test.Data
{
    [TestFixture]
    public class DataContextTest
    {
        private DataContext dataContext;

        [SetUp]
        public void setUp()
        {
            this.dataContext = new StorageDataContext();
        }

        [Test]
        public void Get_IEnumerable_test()
        {
            IEnumerable<PersonRecord> personRecords = 
                this.dataContext.Get<IEnumerable<PersonRecord>>();
            IEnumerable<Person> persons = 
                this.dataContext.Get<IEnumerable<Person>>();

            Assert.AreSame(personRecords, persons);

            Assert.NotNull(personRecords);
            Assert.NotNull(persons);

            Assert.AreEqual(0, personRecords.Count());
            Assert.AreEqual(0, persons.Count());
        }

        [Test]
        public void Get_ICollection_test()
        {
            ICollection<PersonRecord> persons = 
                this.dataContext.Get<ICollection<PersonRecord>>();

            Assert.NotNull(persons);
            Assert.AreEqual(0, persons.Count());
        }
    }
}
