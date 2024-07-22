List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

// Cria uma nova instância da classe Random
Random random = new Random();

// Embaralha a lista usando OrderBy e Random
List<int> listaEmbaralhada = lista.OrderBy(x => random.Next()).ToList();

// Exibe a lista embaralhada
Console.WriteLine("Lista embaralhada: " + string.Join(", ", listaEmbaralhada));