Cliente cliente1 = new Cliente(
    "JASONY",
    "AL000001"
);
 
Cliente cliente2 = new Cliente(
    "LUCIAN",
    "AL000002"
);
 
 
Veiculo veiculo1 = new Veiculo(
    "Toyota Corolla",
    "ABC1234"
);
 
Veiculo veiculo2 = new Veiculo(
    "Honda Civic",
    "XYZ5678"
);
 
 
Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 8),
    5,
    150m
);
 
 
Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 8),
    10,
    200m
);
 
 
Console.WriteLine("SISTEMA DE LOCAÇÃO DE VEÍCULOS");
Console.WriteLine();
 
locacao1.ExibirResumo();
 
Console.WriteLine();
 
locacao2.ExibirResumo();