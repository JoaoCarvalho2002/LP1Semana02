using System;

namespace HardDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd n2s plz!");
            string n1=Console.ReadLine();
            int n2 = int.Parse(n1);
            int j=0;
            int i=0;
            int count = n2 - 1;
            if (n2%2!=0){
                
                for (j = 1; j <= n2; j++){

               for (i = 1; i <= count; i++)  
                   Console.Write(" ");  
               count--;  
               for (i = 1; i <= 2 * j - 1; i++)  
                   Console.Write(n2);  
               Console.WriteLine();  
                }  
           count = 1;  
           for (j = 1; j <= n2 - 1; j++){

               for (i = 1; i <= count; i++)  
                   Console.Write(" ");  
               count++;  
               for (i = 1; i <= 2 * (n2 - j) - 1; i++)  
                   Console.Write(n2);  
               Console.WriteLine();
            }
            }

            else{
                Console.WriteLine("I only want odd n2s!");
                
            }




        }
    }
}
