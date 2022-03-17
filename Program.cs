
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject130Batch
{
    class Program:Object
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 130batch");
            Console.WriteLine("----------");
            Console.WriteLine("Remote changing modified by 2nd developer");
            Console.WriteLine("Local changes creating conflict");
            Console.WriteLine("Creating conflict from remote");
            Human human = new Human();
            human.HumanDetails();
            Human.Speak();
            SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
            swapTwoNumbers.SwapNumbers();
            Console.ReadLine();
        }
    }
}
