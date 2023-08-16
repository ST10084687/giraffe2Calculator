using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giraffe2CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value One: ");
            int valOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value Two: ");
            int valTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("The two numbers added together: " + (valOne + valTwo));
           

            Console.ReadLine();
        }
    }
}
