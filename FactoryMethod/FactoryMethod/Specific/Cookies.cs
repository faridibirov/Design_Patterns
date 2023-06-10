﻿using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Specific
{
    internal class Cookies : IDepartment
    {
        public void Produce()
        {
            Console.WriteLine("Produce Cookies");
        }
    }
}
