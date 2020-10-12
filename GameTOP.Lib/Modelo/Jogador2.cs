using GameTOP.Interface;

namespace GameTOP.Lib.Modelo
{
    public class Jogador2 : IJogador
    {
        public string Name { get;}

        public Jogador2(string name)
        {
            Name = name;
        }
        public string Chuta()
        {
            return $"{Name} is kicking.";
        }

        public string Corre()
        {
            return $"{Name} is running.";
        }

        public string Passa()
        {
            return $"{Name} is passing.";
        }
    }
}