using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int veloM = 80;
            int veloN = 100;
            Console.WriteLine("-=-=-=-=-=-=-=-=- Encontro de Trens -=-=-=-=-=-=-=-");
            Console.Write("-- Qual é a distancia entre a cidade A e cidade B? (em quilometros)\n>>  ");
            int distancia = int.Parse(Console.ReadLine());

            int tempEncontro = (distancia * 60) / (veloM + veloN);
            int quilomM = (veloM * tempEncontro) / 60;
            int quilomN = (veloN * tempEncontro) / 60;

            Console.WriteLine($"O encontro dos trens ocorrerá em {tempEncontro} minutos.");
            Console.WriteLine($"O trem M percorrerá {quilomM}km até o encontro.");
            Console.WriteLine($"O trem N percorrerá {quilomN}km até o encontro.");
            Console.ReadKey();
        }
    }
}
