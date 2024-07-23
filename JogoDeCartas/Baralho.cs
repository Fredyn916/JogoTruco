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

            BaralhoCaralho.Add(new Carta(3, "A", "Espadas"));
            BaralhoCaralho.Add(new Carta(7, "A", "Copas"));
            BaralhoCaralho.Add(new Carta(7, "A", "Ouros"));
            BaralhoCaralho.Add(new Carta(7, "A", "Paus"));

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

            BaralhoCaralho.Add(new Carta(9, "J", "Espadas"));
            BaralhoCaralho.Add(new Carta(9, "J", "Copas"));
            BaralhoCaralho.Add(new Carta(9, "J", "Ouros"));
            BaralhoCaralho.Add(new Carta(9, "J", "Paus"));

            BaralhoCaralho.Add(new Carta(10, "Q", "Espadas"));
            BaralhoCaralho.Add(new Carta(10, "Q", "Copas"));
            BaralhoCaralho.Add(new Carta(10, "Q", "Ouros"));
            BaralhoCaralho.Add(new Carta(10, "Q", "Paus"));

            BaralhoCaralho.Add(new Carta(8, "K", "Espadas"));
            BaralhoCaralho.Add(new Carta(8, "K", "Copas"));
            BaralhoCaralho.Add(new Carta(8, "K", "Ouros"));
            BaralhoCaralho.Add(new Carta(8, "K", "Paus"));
        }

        public void EmbaralharBaralho()
        {
            Random random = new Random();
            BaralhoCaralho = BaralhoCaralho.OrderBy(x => random.Next()).ToList();
        }
    }
}
