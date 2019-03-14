using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Manager : Employee
    {
        public Manager(string name, int paycheck) : base(name)
        {
            Paycheck = paycheck;
        } 

        public int Paycheck { get; set; }

        public int GetPaychekc()
        {
            return Paycheck * 2;
        }
    }
}
