using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas
{
    public class Truco
    {
        Baralho Baralho { get; set; }

        Jogador Jogador1 = new Jogador(1);
        Jogador Jogador2 = new Jogador(2);
        Jogador Jogador3 = new Jogador(3);
        Jogador Jogador4 = new Jogador(4);
        public List<Jogador> Jogadores { get; set; }

        public Jogador[] Dupla1 = new Jogador[2];
        public Jogador[] Dupla2 = new Jogador[2];

        public Jogador[] JogaresRodada = new Jogador[4];

        public int PontosDupla1 { get; set; }
        public int PontosDupla2 { get; set; }
        public int TentoDupla1 { get; set; }
        public int TentoDupla2 { get; set; }

        public Truco()
        {
            Baralho = new Baralho();
            Jogadores = new List<Jogador>();
            Jogadores.Add(Jogador1);
            Jogadores.Add(Jogador2);
            Jogadores.Add(Jogador3);
            Jogadores.Add(Jogador4);
        }

        public void JogarTruco()
        {
            EscolherDuplasAleatoriamente();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"<--- DUPLA 1 --->");
                Console.WriteLine($"Jogador {Dupla1[0].Id} e Jogador {Dupla1[1].Id}");
                Console.WriteLine($"<--------------->");
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"<--- DUPLA 2 --->");
                Console.WriteLine($"Jogador {Dupla2[0].Id} e Jogador {Dupla2[1].Id}");
                Console.WriteLine($"<--------------->");
            }
            PreencherJogadores();
            while (TentoDupla1 <= 10 || TentoDupla2 <= 10)
            {
                PontosDupla1 = 0;
                PontosDupla2 = 0;
                while (PontosDupla1 < 3 || PontosDupla2 < 3)
                {
                    Baralho.EmbaralharBaralho();
                    DistribuirCartas(Baralho);
                }
            }
        }

        public void EscolherDuplasAleatoriamente()
        {
            int contador = 0;
            Random random = new Random();
            List<Jogador> JogadoresEmbaralhados = Jogadores.OrderBy(x => random.Next()).ToList();
            foreach (Jogador x in JogadoresEmbaralhados)
            {
                contador++;
                if (contador == 1)
                {
                    Dupla1[0] = x;
                }
                else if (contador == 2)
                {
                    Dupla1[1] = x;
                }
                else if (contador == 3)
                {
                    Dupla2[0] = x;
                }
                else if (contador == 4)
                {
                    Dupla2[1] = x;
                }
            }
        }

        public void DistribuirCartas(Baralho b)
        {
            int contador = 0;
            foreach (Carta carta in b.BaralhoCaralho)
            {
                contador++;
                if (contador > 0 || contador < 4)
                {
                    Dupla1[0].Mao.Add(carta);
                }
                else if (contador > 3 || contador < 7)
                {
                    Dupla2[0].Mao.Add(carta);
                }
                else if (contador > 6 || contador < 10)
                {
                    Dupla1[1].Mao.Add(carta);
                }
                else if (contador > 11 || contador < 15)
                {
                    Dupla2[1].Mao.Add(carta);
                }
                if(contador == 15)
                {
                    break;
                }
            }
        }

        public void PreencherJogadores()
        {
            JogaresRodada[0] = Dupla1[0];
            JogaresRodada[1] = Dupla1[1];
            JogaresRodada[2] = Dupla2[0];
            JogaresRodada[3] = Dupla2[1];
        }

        public int RodadaJogador(Jogador j)
        {
            int ValorCarta = 0;
            int Contador = 0;
            int NumCarta = 0;

            Console.WriteLine($"<--- MÃO --->");
            foreach (Carta c in j.Mao)
            {
                Contador++;
                Console.WriteLine($"{c.ExibirCarta}= {Contador}");
            }
            Console.WriteLine($"<----------->");
            Carta[] MaoArray = j.Mao.ToArray();
            Console.WriteLine($"Digite o número respectivo a carta deseja jogar:");
            while (NumCarta != 1 && NumCarta != 2 && NumCarta != 3)
            {
                NumCarta = int.Parse(Console.ReadLine());

                if(NumCarta != 1 && NumCarta != 2 && NumCarta != 3)
                {
                    Console.WriteLine("Digite um número válido");
                }
            }

            return ValorCarta;
        }
    }
}
