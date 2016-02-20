﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Id { get; set; }
    }
}
