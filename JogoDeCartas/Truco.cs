using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas
{
    public class Truco
    {
        Jogador Jogador1 = new Jogador(1);
        Jogador Jogador2 = new Jogador(2);
        Jogador Jogador3 = new Jogador(3);
        Jogador Jogador4 = new Jogador(4);
        public List<Jogador> Jogadores { get; set; }
        public Jogador[] Dupla1 = new Jogador[2];
        public Jogador[] Dupla2 = new Jogador[2];
        public int PontosDupla1 { get; set; }
        public int PontosDupla2 { get; set; }

        public Truco()
        {
            Jogadores = new List<Jogador>();
            Jogadores.Add(Jogador1);
            Jogadores.Add(Jogador2);
            Jogadores.Add(Jogador3);
            Jogadores.Add(Jogador4);
        }

        public void EscolherDuplas()
        {
            
        }
    }
}
