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
            double tempdou = double.Parse(temp);
            switch (unit)
            {
                case"c":

                    double f = tempdou * 1.8 + 32;
                    Console.WriteLine(f);
                    break;
                case "f":

                    double c = (tempdou-32) /1.8; 
                    Console.WriteLine(c);
                    break;
            }
        }
    }
}
