using System;
using System.ComponentModel.DataAnnotations;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte b1 = byte.MaxValue;
            byte b2 = byte.MaxValue;

            sbyte sb1 = sbyte.MaxValue;
            sbyte sb2 = sbyte.MinValue;

            int i1 = int.MaxValue;
            int i2 = int.MinValue;

            float f1 = float.MaxValue;
            float f2 = float.MinValue;

            double db1 = double.MaxValue;
            double db2 = double.MinValue;

            ulong ul1 = ulong.MaxValue;
            ulong ul2 = ulong.MinValue;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(db1);
            Console.WriteLine(db2);
            Console.WriteLine(ul1);
            Console.WriteLine(ul2);
        }
    }
}
