using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intPosi = 0, numPar = 0, numImpar = 0, div3 = 0, div7 = 0, count = 0, soma = 0;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Informe um valor inicial:\n>> ");
            int numIn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe um valor final:\n>> ");
            int numFim = Convert.ToInt32(Console.ReadLine());

            while(numIn <= numFim)
            {
                count++;
                // Par e Impar
                if (numIn % 2 == 0)
                    numPar++;
                else
                    numImpar++;
                // Divisivel por 3 e 7
                if (numIn % 3 == 0)
                    div3++;
                if (numIn % 7 == 0)
                    div7++;

                soma = soma + numIn;
                numIn++;
            }
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=- Resultados -=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Tivemos "+ numPar + " números Pares.");
            Console.WriteLine("Tivemos "+ numImpar + " números Impares.");
            Console.WriteLine(div3+" Números divisiveis por 3.");
            Console.WriteLine(div7+" Números divisiveis por 7.");
            Console.WriteLine("Somando todos os números o resultado é "+soma+", é a média é: "+(soma)/count);
            Console.ReadKey();
        }
    }
}
