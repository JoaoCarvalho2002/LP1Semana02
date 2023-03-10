using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            string quest, resp;
            Boolean EXIT=false;
            while(EXIT==false){

                Console.Write("Place your question? ");
                quest = Console.ReadLine();
            if (quest=="Exit" || quest =="exit"){
                EXIT=true;
            }
                resp = quest switch
            {
                "How are you?" => "I'm fine, thank you",

                "What's your name?" =>"Mother",

                "1+1?" =>"2, two plus two is four,Minus one thats three,Quick Maths",

                "Who is the best programmer?"=>"You!!",
                     
                "Exit" =>"Shuting-down",

                "exit" =>"Shuting-down",
                    
                _ => "Não reconheço esta frase",
                     
                  
            };
            Console.WriteLine(resp);

            }

            
        }
    }
}
