using System;

namespace Roguelike
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pontos = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            string escolha = "";

            Console.WriteLine("Bem-vindo ao jogo Roguelike.");
            Console.WriteLine("Por favor, escolha uma das opcções do menu.");
            
            while(escolha != "5")
            {
                Console.WriteLine("1. New game");
                Console.WriteLine("2. High scores");
                Console.WriteLine("3. Instructions");
                Console.WriteLine("4. Credits");
                Console.WriteLine("5. Quit");
                escolha = Console.ReadLine();

                if(escolha == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Vamos começar");
                    Console.WriteLine();
                }
                
                else if (escolha == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Esta é a tabela de High Scores.");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine(pontos[i]);
                    }
                    Console.WriteLine();
                }

                else if (escolha == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Estas são as Instructions");
                    Console.WriteLine("1 - O objectivo é sobreviver aos inimigos e ao local onde o player estará.");
                    Console.WriteLine("2 - O jogador quando move-se, perde 2 Hp. Como o jogador pode se mover duas casa por turno, perde 2 Hp por turno.");
                    Console.WriteLine("3 - Os inmigos movem-se uma casa por turno. O inimigo irá escolher o caminho mais curto para poder apanhar o jogador.");
                    Console.WriteLine("4 - O jogo acaba quando o jogador perde as vidas todas ou quando o jogador pressionar a tecla ESCAPE.");
                    Console.WriteLine("5 - Há power-ups para recolher. Porém vai havendo menos à medida que os níveis vão ficando mais dificeis.");
                    Console.WriteLine("6 - Vai havendo mais inimigos à medida que o jogo vai progredindo.");
                    Console.WriteLine("7 - Há dois tipos de inimigos: minions e boss.");
                    Console.WriteLine("8 - O boss tem 10 pontos de vida enquanto, os minios só têm 5 pontos de vida.");
                    Console.WriteLine("9 - As vidas do jogador dependerá das linhas e das colunas que os níveis tiverem.");
                    Console.WriteLine("10 - Há três tipos de power-ups: small, medium e large.");
                    Console.WriteLine("11 - Small power-ups era comum e aumentam as vidas do jogador em 4 unidades.");
                    Console.WriteLine("12 - Medium power-up aparecem com alguma frequência e aumenta as vidas do jogador em 8 unidades.");
                    Console.WriteLine("13 - Large power-up é mais raro e aumenta as vidas do jogador em 16 unidades.");
                    Console.WriteLine("14 - Se a pontuação obtida estiver entre as 10 melhores, ela será posta na tabela High Score.");
                    Console.WriteLine();
                }

                else if (escolha == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("Credits.");
                    Console.WriteLine("Pessoas que fizeram este trabalho");
                    Console.WriteLine("Leonor Figueiredo nº21902968");
                    Console.WriteLine("João Pedro nº21906096");
                    Console.WriteLine();
                }

                else if (escolha == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("Escolheste sair do jogo.");
                    Console.WriteLine("Os inimigos estarão à tua espera.");
                    Console.WriteLine("Até à proxima.");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opcção inválida");
                    Console.WriteLine();
                }
            }
        }
    }
}
