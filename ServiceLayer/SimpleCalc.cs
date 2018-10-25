using System;
using System.Collections.Generic;
using System.Text;
using DB;

namespace ServiceLayer
{
    public class SimpleCalc : ISimpleCalc
    {
        public double Calc(int one, int two)
        {
            return one + two;
        }

    }
}
