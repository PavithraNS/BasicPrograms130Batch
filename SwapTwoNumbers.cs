using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject130Batch
{
    class SwapTwoNumbers
    {
        //declaration of varibels
        public int first,second,temp;
        //static varible
        public static int third;

        public void SwapNumbers()
        {
            Console.WriteLine("Please enter first number");
            first=Convert.ToInt32(Console.ReadLine()); //10
            Console.WriteLine("Please enter second number");
            second = Convert.ToInt32(Console.ReadLine()); //20
            Console.WriteLine("Before swapping two numbers");
            Console.WriteLine("first numb:"+first+" second numb:"+second);
            temp = first; //temp=10;
            first = second; //first=20;
            second = temp; //second=10;
            Console.WriteLine("After swapped ");
            Console.WriteLine("first numb:" + first + " second numb:" + second);
        }

    }
}
