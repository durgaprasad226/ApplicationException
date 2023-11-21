using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppException
{
    public class DivideByOddException:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by Odd Number";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 > 0)
                {
                    throw new DivideByOddException();
                }
                int z = x / y;
                Console.WriteLine($"The result is {z}");
            }
            catch (DivideByOddException e) 
            {
                Console.WriteLine("Divisor cannot be Odd Number");
            }
            
            
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }
}
