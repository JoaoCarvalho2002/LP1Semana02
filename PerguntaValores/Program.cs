using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Altura");
            string a=Console.ReadLine();
            Console.WriteLine("Raio");
            string r=Console.ReadLine();
            //conversion of strings to int
            int a2 = int.Parse( a );
            int r2 = int.Parse( r );
            //Volume
            double V=Math.PI * (r2 * r2) * a2;
            Console.WriteLine("Volume: "+V);
            //surface area
            double S =(2*Math.PI)*r2*(r2+a2);
            Console.WriteLine("Area Superficial: "+S);
        }
    }
}
