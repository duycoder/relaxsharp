﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {
        public string Origin
        {
            get
            {
                return string.Format("{0} was born on {1}", arg0: Name, arg1: HomePlanet);
            }
        }
    }
}
