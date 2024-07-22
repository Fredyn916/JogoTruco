using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas
{
    public class Jogador
    {
        public int Id { get; set; }
        public List<Carta> Mao { get; set; }

        public Jogador(int id)
        {
            Id = id;
        }
    }
}
