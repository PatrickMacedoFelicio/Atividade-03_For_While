Console.WriteLine("-=-=-=-=-=-=-=-=-=-= Mediana -=-=-=-=-=-=-=-=-=-=-");
Console.Write("Digite o primeiro número:\n>> ");
int i = int.Parse(Console.ReadLine());
Console.Write("Digite o primeiro número:\n>> ");
int j = int.Parse(Console.ReadLine());

double resul = (i + j) / 2;
Console.WriteLine($"A mediana entre {i} e {j} é: {resul}");