using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final2
{
    public interface ISum
    {
        void Sum(double a, double b);
    }

    public class Calc : ISum
    {
        ILogger logger {  get; }

        public Calc(ILogger logger)
        {
            this.logger = logger;
        }
        public void Sum(double a, double b)
        {
            logger.Event($"Сумма первого и второго числа равна: {a+b}");
           
        }
    }
}
