using ru.itpc.trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public class StorageDataContext:DataContext
    {
        public List<PersonRecord> PersonRecords { get; set; }
        public List<DriverLicenseRecord> DriversLicensesRecords { get; set; }
        public List<string> Strings { get; set; }
        public List<int> Integers { get; set; }

        public StorageDataContext()
        {
            this.PersonRecords = new List<PersonRecord>();
            this.DriversLicensesRecords = new List<DriverLicenseRecord>();
            this.Strings = new List<string>();
            this.Integers = new List<int>();
        }

        public T Get<T>()
        {
            return default(T);
        }
    }
}
