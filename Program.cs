using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Barbosa lindo";
            jogador1.idade = 18;

            Console.WriteLine( jogador1.Correr(2405.5f) );
            Console.WriteLine( "Força : " + jogador1.Atacar(600f) );
            
            jogador1.pulando = true;
            Console.WriteLine( "Força : " + jogador1.Atacar(40f) );

        }
    }
}
