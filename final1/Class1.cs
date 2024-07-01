using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    public interface ISum
    {
        double Sum(double a, double b);
    }

    public class Calc : ISum
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
