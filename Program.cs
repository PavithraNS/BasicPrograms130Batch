
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject130Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose program number to execute");
            Console.WriteLine("1:Human program\n2:SwapTwoNumbers\n3:Fibonocie\n5:Reverse number\n4:exit");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    // code block
                    Human human = new Human();
                    human.HumanDetails();
                    Human.Speak();
                    break;
                case 2:
                    // code block
                    SwapTwoNumbers swap = new SwapTwoNumbers();
                    swap.SwapNumbers();
                    break;
                case 3:
                    // code block
                    Fibonocci.FindNumberOfFiboncciSeries();
                    break;
                case 4:
                    // code block
                    return;
                case 5:
                    // code block
                    Console.WriteLine("enter number to make reverse");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.FindReverse(numb);
                    break;
                default:
                    // code block
                    Console.WriteLine("please choose number within given range");
                    break;
            }             
            Console.ReadLine();
        }
    }
}
