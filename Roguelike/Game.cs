using System;

namespace Roguelike
{
    class Game
    {

        private Board board;


        public Game(int n1, int n2)
        {
            int num1 = n1;
            int num2 = n2;
            board = new Board(num1, num2);

        }

        public int Play(int n1, int n2)
        {
            //Começar o jogo
            int n_1 = n1;
            int n_2 = n2;
            Console.WriteLine("Bem-vindo às masmorras.");
            Console.WriteLine("Tente encontrar a saída antes que os inimigos te apanhem.");
            Console.WriteLine("Ou que fiques sem vidas.");

            do
            {
                
                
            } while (board.End(n_1, n_2) != 0);

            return 0;
        }
    }      
}
