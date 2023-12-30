using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Calculator : IAddition
    {
        public double Sum(double numb1, double numb2)
        {
            return numb1 + numb2;
        }
    }
}
