using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv6_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string situacao;
            do
            {
                int primo = 0;
                Console.WriteLine("-=-=-=-=-=-=-=- Números primos -=-=-=-=-=-=-=-");
                Console.Write("-- Digite um número para verificar se é um núemro Primo:\n>> ");
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        primo++;
                }
                if (primo == 2)
                    Console.WriteLine($"\n-- O número {num} é um Número Primo!");
                else
                    Console.WriteLine($"\n --O número {num} não é um Número Primo!");
                Console.Write("\n-- Deseja continuar as verificações?\n(S/N) >> ");
                situacao = Console.ReadLine();
                situacao = situacao.ToUpper();
                Console.Clear();
            } while (situacao == "S");
            Console.Clear();
            Console.WriteLine("-- Obrigado por participar!");
            Console.WriteLine("Digite qualquer coisa para sair...");
            Console.ReadKey();
        }
    }
}
