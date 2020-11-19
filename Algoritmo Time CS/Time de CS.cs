using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Bem vindo a seletiva para o time de CS");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Você gostaria de participar? Sim ou Não?");
            string resposta = Console.ReadLine();

            if(resposta == "Sim"){
                Console.WriteLine(" ");
                Console.WriteLine("Bacana, vamos analisar seu nível!");
                Console.WriteLine(" ");
                Console.WriteLine("Insira sua média escolar por favor (0 a 10)");
                float media = float.Parse(Console.ReadLine());
                Console.WriteLine("Insira sua quantidade de faltas por favor (0 a 20)");
                int faltas = int.Parse(Console.ReadLine());
                
                if(media >= 5 && faltas <= 10){
                    Console.WriteLine(" ");
                    Console.WriteLine("Parabéns! Seja Bem Vindo");
                }else{
                    Console.WriteLine(" ");
                    Console.WriteLine("Que pena! Você precisa de uma média maior ou menor quantidade de faltas!");
                }
            
            
            }else{
                Console.WriteLine(" ");
                Console.WriteLine("Beleza, até mais!");
            }
        }
    }
}
