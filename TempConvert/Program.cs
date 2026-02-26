using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string temp="";
            string unit="";
            //Console.WriteLine("Hello LP!");
            Console.WriteLine("Temperature?");
            temp=Console.ReadLine();
            Console.WriteLine("C or F?");
            unit=Console.ReadLine();
            Console.WriteLine(temp+unit);
        }
    }
}
