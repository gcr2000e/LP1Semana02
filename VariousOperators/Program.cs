using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insire um número inteiro não negativo: ");
            string n = Console.ReadLine();

            byte num = byte.Parse(n);

            Console.WriteLine(num / 2);
            Console.WriteLine(num << 3);
            Console.WriteLine(num ^ 6);
            bool b;

            if (num > 10)
            {
                b = true;
                Console.WriteLine($"{b}");
            }
            else
            {
                b = false;
                Console.WriteLine($"{b}");
            }


        }
    }
}
