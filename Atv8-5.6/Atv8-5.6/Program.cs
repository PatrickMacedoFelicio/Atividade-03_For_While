int resul = 0;
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- Número perfeito -=-=-=-=-==-=-=-=-=-=-");
Console.Write("Digite um número para analisarmos e averiguar se ele é PERFEITO!:\n>> ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i < num; i++){
    if ((num % i) == 0)
        resul = resul + i;
}
Console.Clear();
Console.WriteLine("-=-=-=-=-=-=-=-=-=- Número perfeito -=-=-=-=-=-=-=-=-=-");
if (resul == num)
    Console.WriteLine($"\n-- {num} é um número PERFEITO!!");
else
    Console.WriteLine($"\n-- {num} NÃO é um número perfeito.");