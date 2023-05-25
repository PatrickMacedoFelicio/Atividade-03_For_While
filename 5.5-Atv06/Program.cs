using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("   O algoritmo fará uma sequencia de calculos dependendo do número digitado\naté que o núemro digitado se torne 1.");
            Console.Write("\nDigite um número\n>> ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("\n-=-=-=-=-=- " + n + " é Par -=-=-=-=-=-");
                    Console.WriteLine(n + " / 2" + " = " + (n = n / 2));
                }
                else
                {
                    Console.WriteLine("\n-=-=-=-=-=- " + n + " é Impar -=-=-=-=-=-");
                    Console.WriteLine(n + " * 3 + 1" + " = " + (n = n * 3 + 1));
                }
            }
            Console.WriteLine("\n-- O número digitado se tornou 1\nMuito obrigado por participar :)");
            Console.ReadKey();
        }
    }
}
