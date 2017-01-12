using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = Inputs();
            int value2 = Inputs();

            while (true)
            {
                char sign = Operation();

                if (sign.ToString().Equals("a", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(CalcUtility.Add(value1, value2));
                    break;
                }
                else if (sign.ToString().Equals("s", StringComparison.OrdinalIgnoreCase))
                {

                    Console.WriteLine(CalcUtility.Sub(value1, value2));
                    break;
                }
                else if (sign.ToString().Equals("M", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(CalcUtility.Multi(value1, value2));
                    break;
                }
                else if (sign.ToString().Equals("D", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(CalcUtility.Dvide(value1, value2));
                    break;
                }
                else
                {
                    Console.WriteLine("please select a correct operation!!");
                    continue;
                }
            }
        }
        static int Inputs()
        {
            int convInput;

            while (true)
            {
                string input = "Please insert your value = ";
                Console.Write(input);

                input = Console.ReadLine();
                if (Int32.TryParse(input, out convInput))
                {
                    return convInput;
                }
                else
                {
                    Console.WriteLine("please try integer number!!");
                    Console.WriteLine();
                }
            }
        }
        static char Operation()
        {
            while (true)
            {
                Console.WriteLine("Please insert an operation ");
                Console.Write("Add , Substrac , Multply , Divide = ");

                string operation = Console.ReadLine();
                char convOperation;

                if (Char.TryParse(operation, out convOperation))
                {
                    return convOperation;
                }
                else
                {
                    Console.WriteLine("Please select A for addition ,S for Substrac,M for multiply or D for divide");
                }
            }
        }
       
    }
}
