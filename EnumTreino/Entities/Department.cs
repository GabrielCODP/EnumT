﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnumTreino.Entities
{
    class Department
    {
        public string Name { get; private set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
