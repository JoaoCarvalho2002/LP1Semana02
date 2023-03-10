using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inteiro");
            string n1=Console.ReadLine();
            Console.WriteLine("Caracter");
            string char1=Console.ReadLine();
            
            int n2 = int.Parse( n1 );
            int n3=n2;
            Console.WriteLine();
            for (int i =1; i<=n2;++i){
                for (int j =1;j<=i;++j){
                    Console.Write(char1);
                }
                Console.WriteLine();

            }
         
            
            
                
        }
    }
}
