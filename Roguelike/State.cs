using System;

namespace Roguelike
{
    public enum State
    {
        N, //Significa que há nada aqui

        B, //Há um boss aqui.

        M, //Há um minion aqui

        P, //O jogador (player) está aqui.

        E, //Saída aqui. (Exit)

        Bl //Está bloqueado
    }    
}
