using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;

            Console.WriteLine("Results");
            Console.WriteLine(num1 + " + " + num2 + " = " + num3);
            //print
            Console.ReadLine();


        }
    }
}
