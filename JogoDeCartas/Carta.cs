using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas
{
    public class Carta
    {
        public int Id { get; set; }
        public string NumOuCarta { get; set; }
        public string Naipe { get; set; }

        public Carta(int id, string numCarta, string naipe)
        {
            Id = id;
            NumOuCarta = numCarta;
            Naipe = naipe;
        }

        public string ExibirCarta()
        {
            return $"| {NumOuCarta} - {ConverterNaipeParaSimbolo()} | ";
        }

        public string ConverterNaipeParaSimbolo()
        {
            switch (Naipe)
            {
                case "Espadas":
                    return "♠";
                case "Paus":
                    return "♣";
                case "Ouros":
                    return "♦";
                case "Copas":
                    return "♥";
            }
            return Naipe;
        }
    }
}
