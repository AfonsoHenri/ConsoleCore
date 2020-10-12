using GameTOP.Lib.Modelo;
using GameTOP.Modelo;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(new Jogador2("Afonso"),new Jogador1("Afonso"));
            jogo.IniciarJogo();
        }
    }

}

