using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject130Batch
{
    class ReverseNumber
    {
        public static void FindReverse(int number)
        {
            int remainder = 0, reverse = 0;
            while (number>0)
            {
                remainder = number % 10; //1234%10=4
                reverse = (reverse * 10) + remainder; //4
                number = number / 10; //123
            }
            Console.WriteLine(reverse);
        }
    }
}
