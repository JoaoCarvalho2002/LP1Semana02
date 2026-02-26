using System;
using System.Globalization;


namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            string temp="";
            string unit="";
            Console.Write("Temperature: ");
            temp=Console.ReadLine();

            Console.Write("Unit (C/F): ");
            unit=Console.ReadLine();

            //Convertion from string to double
            double tempdou = double.Parse(temp);
            switch (unit)
            {
                case "C":

                    double f = tempdou * 1.8 + 32;
                    Console.WriteLine($"{tempdou:F2} C = {f:F2} F");
                    Console.WriteLine("Absolute value: "+$"{Math.Abs(f):F2}");
                    break;

                case "F":

                    double c = (tempdou-32) /1.8; 
                    Console.WriteLine($"{tempdou:F2} F = {c:F2} C");
                    Console.WriteLine("Absolute value: "+$"{Math.Abs(c):F2}");
                    break;
                // incase the input is not desired
                default:
                    Console.WriteLine("Invalid unit"); 
                    break;   
            }
        }
    }
}
