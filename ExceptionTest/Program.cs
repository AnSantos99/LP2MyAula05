using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print out text
            Console.WriteLine("Insere um numero inteiro");

            // Try to run this block of code
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido : {i}");
            }

            // Catches Format type of exceptions
            catch (FormatException b)
            {
                Console.WriteLine("Format exception problem. " + b.Message);
            }

            // Catches Overflow type of exception
            catch (OverflowException c)
            {
                Console.WriteLine("Overflow Exception" + c.Message);
            }

            // Catches any kind of general Exception
            catch (Exception a)
            {
                Console.WriteLine("Ocorreu o seguinte problema" + a.Message);
            }

            // Always executes with out without exception
            finally 
            {
                Console.WriteLine("Thank you for using this program. With or" +
                    " without Exception");
            }
            
        }
    }
}
