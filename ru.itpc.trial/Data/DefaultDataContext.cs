using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public static class DefaultDataContext
    {
        private static DataContext instance;

        // Самый простой вариант без дополнительных проверок, т.к. большего тут вроде бы не требуется.
        public static DataContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StorageDataContext();
                }

                return instance;
            }
        }
    }
}
