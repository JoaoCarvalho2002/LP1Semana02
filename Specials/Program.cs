using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {            
            int xI = int.MaxValue;
            int xi = int.MinValue;
            
            short xSH = short.MaxValue;
            short xsh = short.MinValue;
            
            sbyte xSB = sbyte.MaxValue;
            sbyte xsb = sbyte.MinValue;
            
            decimal xDC = decimal.MaxValue;
            decimal xdc = decimal.MinValue;

            long xL = long.MaxValue;
            long xl = long.MinValue;

            float xf = float. PositiveInfinity;
            double xd = double. PositiveInfinity;

            Console.WriteLine(xI);
            Console.WriteLine(xi);
            Console.WriteLine(xSH);
            Console.WriteLine(xsh);
            Console.WriteLine(xSB);
            Console.WriteLine(xsb);
            Console.WriteLine(xDC);
            Console.WriteLine(xdc);
            Console.WriteLine(xL);
            Console.WriteLine(xl);
            Console.WriteLine(xf);
            Console.WriteLine(xd);

            int auxI = int.MaxValue;
            Console.WriteLine(( int) ( auxI + 1));

            float auxF = float.MaxValue;
            Console.WriteLine(( float) ( auxF + 1));

            double auxD = double.MaxValue;
            Console.WriteLine(( double) ( auxD + 1));
            
            float floataux1,floataux2;
            floataux1=floataux2=10000.0f;
            Console.WriteLine(floataux1==floataux2+0.0001f);
        }
    }
}
