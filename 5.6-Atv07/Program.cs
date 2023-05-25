using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resto = 0;
            Console.WriteLine("-=-=-=-=-=-=-=- M.D.C -=-=-=-=-=-=-=-");
            Console.Write("-- Digite um valor:\n>> ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("-- Digite outro valor:\n>> ");
            int v2 = int.Parse(Console.ReadLine());

            while(v2 != 0){
                resto = v1 % v2;
                v1 = v2;
                v2 = resto;
            }
            Console.Clear();
            Console.WriteLine("-=-=-=-=-=-=-=- Resultado M.D.C -=-=-=-=-=-=-=-");
            Console.WriteLine($"O Máximo Divisor Comum é de {v1}");
            Console.ReadKey();
        }
    }
}
