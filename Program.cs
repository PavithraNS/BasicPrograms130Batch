
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("1:Human program\n2:SwapTwoNumbers\n3:Fibonocie\n5:Reverse number\n6:Addition\n4:exit");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                
                case 1:
                    // code block
                    int a = 30;
                    int b = 30;
                    int res = a.CompareTo(b); //0,1,-1
                    Console.WriteLine(res);
                    //Human human = new Human();
                    //human.HumanDetails();
                    //Human.Speak();
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
                    ReverseNumber.FindReverse(numb); //method argument
                    break;
                case 6:
                    Addition.Add(10,20);
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
