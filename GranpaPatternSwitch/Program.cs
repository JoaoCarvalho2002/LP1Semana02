using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string quest, resp;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            quest = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            resp = quest switch
            {
                "How are you?" => "I'm fine, thank you",

                "What's your name?" =>"Gran'pa",
                     
                "What's your mission?" =>"Destroy mankind!",
                    
                _ => "You got me, I'm not THAT smart!",
                     
                  
            };

            // Responder adequadamente
            Console.WriteLine(resp);
        }
    }
}
