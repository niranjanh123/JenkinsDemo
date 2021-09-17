using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public interface IArithOps
    {
        float Add(float x, float y);
        float Sub(float x, float y);
        float Mul(float x, float y);
        float Div(float x, float y);
    }
}