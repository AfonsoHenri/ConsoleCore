using GameTOP.Interface;

namespace GameTOP.Modelo
{
    public class Jogo
    {
        public IJogador JogadorA { get; set;}
        public IJogador JogadorB { get; set; }
        public Jogo(IJogador jogadorA, IJogador jogadorB)
        {
            JogadorA = jogadorA;
            JogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(JogadorA.Passa());
            System.Console.WriteLine(JogadorA.Corre());
            System.Console.WriteLine(JogadorA.Chuta());

            System.Console.WriteLine("\nPróximo Jogador:\n");

            System.Console.WriteLine(JogadorB.Passa());
            System.Console.WriteLine(JogadorB.Corre());
            System.Console.WriteLine(JogadorB.Chuta());
        }
    }
}