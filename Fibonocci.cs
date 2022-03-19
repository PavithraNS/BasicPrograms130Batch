using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject130Batch
{
    class Fibonocci
    {
        //instance varibles

        public static void FindNumberOfFiboncciSeries()
        {
            int first = 0, second = 1, res = 0;
            int length = 0; //10
            Console.WriteLine("Please enter n value to generate numb of fibonocci series");
            length = Convert.ToInt32(Console.ReadLine()); //10

            Console.WriteLine(length+" Fibonoccie series are:");
            Console.Write(" "+res);//0 1 1
            Console.WriteLine(first+" "+second);
            for (int i = 1; i < length; i++)
            {
                first = second; // 1
                second = res; // 1
                res = first + second;
                Console.Write(" " + res); //0 1 1 2
            }
        }
    }
}
