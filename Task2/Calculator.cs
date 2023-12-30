using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calculator : IAddtition
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger) { Logger = logger; }

        public double Sum(double numb1, double numb2)
        {
            return numb1 + numb2;
        }
    }
}
