using System;

namespace ProagramTeste 
{
    public class VotingSecundari
    {
        public int Votos { get; set; }
        public string Name { get; set; }

        public VotingSecundari() {}
        public VotingSecundari(string name, int votos)
        {
            Name = name;
            Votos = votos;
        }
    }
}
