using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
    }
}
