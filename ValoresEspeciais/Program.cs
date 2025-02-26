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

            double d3 = double.PositiveInfinity;
            double d4 = double.NegativeInfinity;

            float f3 = float.PositiveInfinity;
            float f4 = float.NegativeZero;

            float f5 = float.NaN;
            double d5 = double.NaN;

            uint ui1 = (uint)short.MaxValue;


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
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
            Console.WriteLine(d5);
            Console.WriteLine(f5);
            Console.WriteLine((short)(ui1+1));
        }
    }
}
