﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    public class FireFighter
    {
        string name;
        public FireFighter(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
    }
}
