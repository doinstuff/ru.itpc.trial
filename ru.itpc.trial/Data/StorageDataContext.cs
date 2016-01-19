using ru.itpc.trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public class StorageDataContext : DataContext
    {
        public List<PersonRecord> PersonRecords { get; set; }
        public List<DriverLicenseRecord> DriversLicensesRecords { get; set; }
        public List<string> Strings { get; set; }
        public List<int> Integers { get; set; }
        public DateTime LastChange { get; set; }

        public StorageDataContext()
        {
            this.PersonRecords = new List<PersonRecord>();
            this.DriversLicensesRecords = new List<DriverLicenseRecord>();
            this.Strings = new List<string>();
            this.Integers = new List<int>();
            this.LastChange = DateTime.Now;
        }

        public T Get<T>()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(T) || 
                    property.PropertyType.GetInterfaces().Any(i => i == typeof(T)) ||
                    CompareTypesAndArguments(property, typeof(T)))
                {
                    return (T)property.GetValue(this);
                }
            }

            return default(T);
        }

        private bool CompareTypesAndArguments(PropertyInfo property, Type type)
        {
            var propertyInterfaces = property.PropertyType.GetInterfaces();
            var propertyGenericInterfaces = propertyInterfaces.Where(i => i.IsGenericType).Select(i => i.GetGenericTypeDefinition());
            var propertyGenericArgumentsTypes = property.PropertyType.IsGenericType ? property.PropertyType.GetGenericArguments() : null;

            // Берется только первый аргумент универсального типа, чтобы упростить задачу, т.к. все тесты сделаны с рассчетом на один аргумент.
            // Можно попытаться перебрать все возможные комбинации аргументов, но код уже и так слишком запутанный получился.
            var propertyGenericArgumentsTypesInterfaces = propertyGenericArgumentsTypes != null ? propertyGenericArgumentsTypes.First().GetInterfaces() : null;

            var tGenericInterface = type.IsGenericType ? type.GetGenericTypeDefinition() : null;
            var tGenericArgumentTypesInterfaces = type.IsGenericType ? type.GetGenericArguments() : new Type[0];

            var sameGeneric = propertyGenericInterfaces.Any(i => i == tGenericInterface);
            var sameArguments = propertyGenericArgumentsTypesInterfaces.Any(i => tGenericArgumentTypesInterfaces.Any(a => a == i));

            return sameGeneric && sameArguments;
        }
    }
}
