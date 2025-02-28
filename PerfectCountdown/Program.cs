using System;
using System.Xml.XPath;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int result;

            while(true)
            {
              Console.Write("Start number: ");
              string start = Console.ReadLine();
              Console.Write("Step Number: ");
              string step = Console.ReadLine();

              int num1 = int.Parse(start);
              int num2 = int.Parse(step);

              if(num1 > num2)
              {
                result = num1 / num2;
                result %= num2;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(result);
                break;
              }

              if(num1 <= num2 && num1 / num2 == 0)
              {
                Console.WriteLine("Start number must be higher than step number. Try again."); 
              }

              if(num1 < 1 || num2 < 1)
              {
                Console.WriteLine("Out-of-range start or step. Try again.");
              }

              if(num2 / num1 != 0)
              {
                Console.WriteLine("Start not divisible by step. Try again.");
              }

            }
        }
    }
}
