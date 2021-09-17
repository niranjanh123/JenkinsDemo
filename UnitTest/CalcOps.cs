using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class CalcOps : ICalcOps
    {
        public float Add(float x, float y)
        {
            return (x + y);
        }

        public double Addition(double x, double y)
        {
            return (x + y);
        }

        public string Comp(string var1)
        {
            return var1;
        }

        public float Div(float x, float y)
        {
            return (x / y);
        }

        public float Mul(float x, float y)
        {
            return (x * y);
        }

        public double Net_salary(double amt)
        {
            return (amt * 12);
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public float Sub(float x, float y)
        {
            return (x - y);
        }
    }
}
