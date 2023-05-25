using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fator;
            Console.WriteLine("-=-=-=-=-=-=-=- Fatorial -=-=-=-=-=-=-");
            Console.Write("-- Digite um número para fazer o fatorial\n>> ");
            num = int.Parse(Console.ReadLine());
            fator = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fator = fator * i;
            }
            Console.Clear();
            Console.WriteLine("\n-=-=-=-=-=-=-=- Resultado FAtorial -=-=-=-=-=-=-=-");
            Console.WriteLine($"O fatorial de {num}! é {fator}");
            Console.ReadKey();
        }
    }
}
