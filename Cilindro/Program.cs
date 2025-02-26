using System;
using System.Reflection;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double v; double s;
    
            Console.WriteLine("Insere a altura do cilindro: ");
            string altura = Console.ReadLine();

            Console.WriteLine("Insere o raio do cilindro: ");
            string raio = Console.ReadLine();

            double h = double.Parse(altura);
            double r = double.Parse(raio);

            v = Math.PI * Math.Pow(r, 2) * h;
            
            s = 2 * Math.PI * r * (r + h);

            Console.WriteLine($"Volume do cilindro: {v:f3}");
            Console.WriteLine($"Área do cilindro: {s:f3}");
        }
    }
}
