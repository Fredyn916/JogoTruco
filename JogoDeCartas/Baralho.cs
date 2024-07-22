using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas
{
    public class Baralho
    {
        public List<Carta> BaralhoCaralho { get; set; }

        public Baralho()
        {
            BaralhoCaralho = new List<Carta>();

            BaralhoCaralho.Add(new Carta(3, "Ás", "Espadas"));
            BaralhoCaralho.Add(new Carta(7, "Ás", "Copas"));
            BaralhoCaralho.Add(new Carta(7, "Ás", "Ouros"));
            BaralhoCaralho.Add(new Carta(7, "Ás", "Paus"));

            BaralhoCaralho.Add(new Carta(6, "2", "Espadas"));
            BaralhoCaralho.Add(new Carta(6, "2", "Copas"));
            BaralhoCaralho.Add(new Carta(6, "2", "Ouros"));
            BaralhoCaralho.Add(new Carta(6, "2", "Paus"));

            BaralhoCaralho.Add(new Carta(5, "3", "Espadas"));
            BaralhoCaralho.Add(new Carta(5, "3", "Copas"));
            BaralhoCaralho.Add(new Carta(5, "3", "Ouros"));
            BaralhoCaralho.Add(new Carta(5, "3", "Paus"));

            BaralhoCaralho.Add(new Carta(14, "4", "Espadas"));
            BaralhoCaralho.Add(new Carta(14, "4", "Copas"));
            BaralhoCaralho.Add(new Carta(14, "4", "Ouros"));
            BaralhoCaralho.Add(new Carta(1, "4", "Paus"));

            BaralhoCaralho.Add(new Carta(13, "5", "Espadas"));
            BaralhoCaralho.Add(new Carta(13, "5", "Copas"));
            BaralhoCaralho.Add(new Carta(13, "5", "Ouros"));
            BaralhoCaralho.Add(new Carta(13, "5", "Paus"));

            BaralhoCaralho.Add(new Carta(12, "6", "Espadas"));
            BaralhoCaralho.Add(new Carta(12, "6", "Copas"));
            BaralhoCaralho.Add(new Carta(12, "6", "Ouros"));
            BaralhoCaralho.Add(new Carta(12, "6", "Paus"));

            BaralhoCaralho.Add(new Carta(11, "7", "Espadas"));
            BaralhoCaralho.Add(new Carta(2, "7", "Copas"));
            BaralhoCaralho.Add(new Carta(4, "7", "Ouros"));
            BaralhoCaralho.Add(new Carta(11, "7", "Paus"));

            BaralhoCaralho.Add(new Carta(0, "8", "Espadas"));
            BaralhoCaralho.Add(new Carta(0, "8", "Copas"));
            BaralhoCaralho.Add(new Carta(0, "8", "Ouros"));
            BaralhoCaralho.Add(new Carta(0, "8", "Paus"));

            BaralhoCaralho.Add(new Carta(0, "9", "Espadas"));
            BaralhoCaralho.Add(new Carta(0, "9", "Copas"));
            BaralhoCaralho.Add(new Carta(0, "9", "Ouros"));
            BaralhoCaralho.Add(new Carta(0, "9", "Paus"));

            BaralhoCaralho.Add(new Carta(0, "10", "Espadas"));
            BaralhoCaralho.Add(new Carta(0, "10", "Copas"));
            BaralhoCaralho.Add(new Carta(0, "10", "Ouros"));
            BaralhoCaralho.Add(new Carta(0, "10", "Paus"));

            BaralhoCaralho.Add(new Carta(9, "Valete", "Espadas"));
            BaralhoCaralho.Add(new Carta(9, "Valete", "Copas"));
            BaralhoCaralho.Add(new Carta(9, "Valete", "Ouros"));
            BaralhoCaralho.Add(new Carta(9, "Valete", "Paus"));

            BaralhoCaralho.Add(new Carta(10, "Rainha", "Espadas"));
            BaralhoCaralho.Add(new Carta(10, "Rainha", "Copas"));
            BaralhoCaralho.Add(new Carta(10, "Rainha", "Ouros"));
            BaralhoCaralho.Add(new Carta(10, "Rainha", "Paus"));

            BaralhoCaralho.Add(new Carta(8, "Rei", "Espadas"));
            BaralhoCaralho.Add(new Carta(8, "Rei", "Copas"));
            BaralhoCaralho.Add(new Carta(8, "Rei", "Ouros"));
            BaralhoCaralho.Add(new Carta(8, "Rei", "Paus"));
        }
    }
}
