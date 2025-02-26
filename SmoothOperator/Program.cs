using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere um número inteiro: ");
            string n = Console.ReadLine();

            sbyte num = sbyte.Parse(n);

            Console.WriteLine(--num);
            Console.WriteLine(++num);
        }
    }
}
