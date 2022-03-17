using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloProject130Batch
{
    class Human
    {
        //variables
        public string name="Harish";
        public long phoneNumber=9887985912;

        //methods

        public static void Speak()
        {
            Console.WriteLine("He/She can speak");
        }

        public void HumanDetails()
        {
            Console.WriteLine("Name:"+name+" "+phoneNumber);
        }
    }
}
