
using GameTOP.Interface;

namespace GameTOP.Lib.Modelo
{
    public class Jogador1 : IJogador
    {
        public string Nome { get;}

        public Jogador1(string nome)
        {
            Nome = nome;
        }

        public string Corre()
        {
            return $"{Nome} está correndo.";
        }

        public string Chuta()
        {
            return $"{Nome} está chutando.";
        }

        public string Passa()
        {
            return $"{Nome} está passando.";
        }
    }
}