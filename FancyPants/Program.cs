using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyPants
{
    class Program
    {
        static void Main(string[] args)
        {
            int low, high, a, b = 0;

            // Get the Input Values
            Console.WriteLine("Please Input the value for Low : ");
            low = getInput();
            Console.WriteLine("Please Input the value for High : ");
            high = getInput();
            Console.WriteLine("Please Input the value for A : ");
            a = getInput();
            Console.WriteLine("Please Input the value for B : ");
            b = getInput();

            if (low < 0 || high < 0 || a < 1 || b < 1 || low > high)
            {
                Console.WriteLine("Invalid Inputs! ");
            }
            else
            {
                // Make a call to fancyPantsCheck function for the output
                fancyPantsCheck(low, high, a, b);
            }

            Console.Read();

        }

        static int getInput()
        {
            try
            {
                // Read the input value and pass it the main function.
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
            }
        }

        static void fancyPantsCheck(int low, int high, int a, int b)
        {
            Console.WriteLine("Output:");

            for (int i = low; i <= high; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    Console.WriteLine("FancyPants");
                }
                else if (i % a == 0 && i % b != 0)
                {
                    Console.WriteLine("Fancy");
                }
                else if (i % a != 0 && i % b == 0)
                {
                    Console.WriteLine("Pants");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }
    }

}
