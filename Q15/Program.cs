﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            var softwareManufacturers = new List<string>()
{
   "Microsoft", "Apple", "Oracle"
};

            var hardwareManufacturers = new List<string>()
{
   "Apple", "Samsung", "Intel"
};

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);        }
    }
}
