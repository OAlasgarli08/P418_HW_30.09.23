using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P418_HW_30._09._23_Practical2
{
    internal class Factorial : CommonCalc
    {
        public int GetFactorial(int a)
        {
            int result = 1;
            for (int i = 1; i < a; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
