using System;

namespace UnitTest
{
    public interface ICalcOps
    {
        float Add(float x, float y);
        float Sub(float x, float y);
        float Mul(float x, float y);
        float Div(float x, float y);
        double Addition(double x,double y);
        double Power(double x, double y);
        double Net_salary(double amt);
        string Comp(string var1);
    }
}
