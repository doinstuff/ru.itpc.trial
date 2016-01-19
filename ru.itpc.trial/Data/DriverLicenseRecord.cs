using ru.itpc.trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public class DriverLicenseRecord : DriverLicense
    {
        private int id;

        public string Class
        {
            get;
            set;
        }

        public DateTime Expires
        {
            get;
            set;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public DateTime Issued
        {
            get;
            set;
        }

        public DateTime OwnerBirthDate
        {
            get;
            set;
        }

        public string OwnerFirstName
        {
            get;
            set;
        }

        public string OwnerLastName
        {
            get;
            set;
        }

        public DriverLicenseRecord(int id, string licenseClass, DateTime expiration, PersonRecord person)
        {
            this.id = id;
            this.Class = licenseClass;
            this.Expires = expiration;
            this.OwnerFirstName = person.FirstName;
            this.OwnerLastName = person.LastName;
            this.OwnerBirthDate = person.BirthDate;
        }
    }
}
