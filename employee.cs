using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string GetName()
        {
            return $"my name is {Name}";
        }
    }
}
