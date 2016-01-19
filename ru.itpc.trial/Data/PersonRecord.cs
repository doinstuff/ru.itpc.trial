using ru.itpc.trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public class PersonRecord : Person
    {
        private readonly string id;
        private readonly string firstName;
        private readonly string lastName;
        private readonly DateTime birthDate;

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        // С идентификатором и датой рождения непонятная история. Нет теста, который бы их заполнял при создании объекта,
        // поэтому сделал их необязательными аргументами.
        public PersonRecord(string firstName, string lastName, string id = "", DateTime birthDate = default(DateTime))
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.birthDate = birthDate;
        }
    }
}
