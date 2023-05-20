using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv04_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=- Potenciação -=-=-=-=-=-");
            Console.Write("Digite o número base para a ponteciação:\n>> ");
            int numBase = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente para a ponteciação:\n>> ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = numBase;
            do
            {
                resultado = resultado * numBase;
                expoente--;
            } while(expoente != 1);
            Console.WriteLine($"\n-- O resultado da Potencia é: {resultado}");
            Console.ReadKey();
        }
    }
}
