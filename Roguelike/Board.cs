using System;

namespace Roguelike
{
    class Board
    {
        private State[,] state;

        public Board(int n1, int n2)
        {
            state = new State [n1, n2];
        }

        public int End(int n, int m)
        {
            //Indicar que o jogo acabou
            int n1 = n;
            int n2 = m;
            Console.WriteLine("Parece que o jogo acabou.");
            Console.WriteLine("Se quiser repetir, só precisa de escolher New Game");
            
            for(int i = 0; i < n1; i++)
            {
                for(int j = 0; j < n2; j++)
                {
                    if(state[i, j] == State.N)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }      
}
