﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurswalter.Core.Interfaces
{
    interface IModifyCourse
    {
        string ErrorMessage { get; }
        bool AddUser(IPerson person);
        bool DeleteUser(IPerson person);
        bool EditUser(IPerson person);
    }
}