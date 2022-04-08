using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    internal class Numbers
    {
    public int FindMinimum(int number1, int number2)
        {
            int Min;
            Min = (number1 < number2) ? number1: number2;
            return Min;
        }
    public int FindMinimum(int number1, int number2, float number3)
        {
            float min = 0;
            if ((number1 < number2) && (number1 < number3))
            {
                min = number1;
            }
            else if((number2 < number1) && (number2 < number3))
            {
                min = number2;
            }
            else if((number3 < number1) && (number3 < number2))
            {
                min = number3;
            }
            return (int)min;
        }
        public int FindMaximum(int number1, int number2)
        {
            int max;
            max = (number1 > number2) ? number1 : number2;
            return max;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            float max = 0;
            if ((number1 > number2) && (number1 > number3))
            {
                max = number1;
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                max = number2;
            }
            else if ((number3 > number1) && (number3 > number2))
            {
                max = number3;
            }
            return (int)max;
        }
    }
}
