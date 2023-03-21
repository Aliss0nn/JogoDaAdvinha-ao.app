using System.Xml;

namespace JogodaAdvinhaçao.app
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();
            int num = numeroAleatorio.Next(1, 20);
            Console.WriteLine(num);
            Console.WriteLine("***********************************");
            Console.Write("Bem Vindo(a) ao Jogo da Adivinhação\n");
            Console.Write("***********************************\n");

            Console.WriteLine("Escolha o nível de dificuldade:\n");
            Console.Write(" [1] Fácil" + " " + " [2] Médio" + " " + " [3] Difícil" + " \n");
            Console.WriteLine();
            Console.Write("Escolha: ");
            int dificuldade = int.Parse(Console.ReadLine());
                       
            Console.WriteLine();
            Console.Write("De o seu primeiro palpite: ");
            
            int palpite = int.Parse(Console.ReadLine());
            int pontuacao = 1000;
            int tentativas = 0;
            
            if (dificuldade == 1)
            {
                tentativas = 15;               
            } 
            else if ( dificuldade == 2)
            {
                tentativas = 10;
            }
            else if ( dificuldade == 3)
            {
                tentativas = 5;
            }


            for (int i = 1; i <= tentativas; i++)
                                                 
            {
                Console.WriteLine($"Tentativa: {i}/{tentativas}" );


                if (palpite > num)
                {
                    pontuacao -= Math.Abs((palpite - num) / 2);
                    Console.WriteLine("tente um número MENOR");
                    Console.WriteLine();
                    Console.WriteLine( "Sua Pontuação é " + pontuacao);
                    Console.WriteLine();
                    Console.WriteLine("Tente novamente\n ");                   
                    palpite = int.Parse(Console.ReadLine());
                }

                
                else if (palpite < num)
                {
                    pontuacao -= Math.Abs((palpite - num) / 2);
                    Console.WriteLine("tente um número MAIOR");
                    Console.WriteLine();
                    Console.WriteLine("Sua Pontuação é " + pontuacao);
                    Console.WriteLine();
                    Console.WriteLine("Tente novamente\n ");
                    palpite = int.Parse(Console.ReadLine());
                }

                else if (palpite == num)
                {
                    Console.Write(" Você acertou,PARABÉNS!!!");
                    Console.WriteLine("Sua Pontuação é " + pontuacao);
                    break;
                }

                if ( i == tentativas)
                {
                    if (palpite == num)
                        continue;
                   
                    else
                    {
                        Console.Write("  PERDEU MANÉ  ");
                    }
                }
                    
                
            }
            Console.WriteLine();
            
            Console.ReadLine();
          }
     }
}   
