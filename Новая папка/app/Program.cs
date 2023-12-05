
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Fraction num1 = new Fraction(8, 4);
            Fraction num2 = new Fraction(8, 17);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            num1.set_denominator(3);
            Console.WriteLine(num1.get_denominator());
            Console.WriteLine(num1.ToString());
        }
    }
}
