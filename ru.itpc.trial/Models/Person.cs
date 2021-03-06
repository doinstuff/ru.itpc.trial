﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Models
{
    public interface Person : Identified<string>
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime BirthDate { get; }
    }
}
