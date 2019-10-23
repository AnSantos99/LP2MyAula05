using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir informacao
            Console.WriteLine("Insere um numero inteiro");

            // Tenta correr este bloco
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido : {i}");
            }

            catch (FormatException b)
            {
                Console.WriteLine("Format exception problem. " + b.Message);
            }

            catch (OverflowException c) 
            {
                Console.WriteLine("Overflow Exception" + c.Message);
            }

            // Apanha excepcoes se algo for diferrente
            catch (Exception a)
            {
                Console.WriteLine("Ocorreu o seguinte problema" + a.Message);
            }
            
        }
    }
}
