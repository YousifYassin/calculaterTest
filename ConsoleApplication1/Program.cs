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
                    Console.WriteLine(Add(value1, value2));
                    break;
                }
                else if (sign.ToString().Equals("s", StringComparison.OrdinalIgnoreCase))
                {

                    Console.WriteLine(Sub(value1, value2));
                    break;
                }
                else if (sign.ToString().Equals("M", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Multi(value1, value2));
                    break;
                }
                else if (sign.ToString().Equals("D", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Dvide(value1, value2));
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
        static int Add(int var1, int var2)
        {
            return var1 + var2;
        }
        static int Sub(int var1, int var2)
        {
            return var1 + var2;
        }
        static int Multi(int var1, int var2)
        {
            return var1 * var2;
        }
        static int Dvide(int var1, int var2)
        {
            return var1 / var2;
        }
    }
}
