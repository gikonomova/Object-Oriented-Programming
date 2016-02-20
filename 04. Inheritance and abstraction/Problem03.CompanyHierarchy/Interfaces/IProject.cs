﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string Name { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }
        void CloseProject();

    }
}
