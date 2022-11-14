﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IComparableApp
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            var other = (Employee)obj;
            if (this.Salary < other.Salary)
                return -1;
            else if (this.Salary == other.Salary)
                return 0;
            else
                return 1;
        }

        public override string? ToString()
        {
            return $"{Id,-5} {FullName,-25} {Salary,-7}";
        }
    }
}
