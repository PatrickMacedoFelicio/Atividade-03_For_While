using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv01_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            int ent0a25 = 0, ent26a50 = 0, ent51a75 = 0, ent76a100 = 0;
            do
            {
                Console.Write(">> Digite um número: ");
                num = double.Parse(Console.ReadLine());
                if ((num >= 0) && (num <= 25.9))
                    ent0a25++;
                if ((num >= 26) && (num <= 50.9))
                    ent26a50++;
                if ((num >= 51) && (num <= 75.9))
                    ent51a75++;
                if ((num >= 76) && (num <= 100))
                    ent76a100++;
            } while (num >= 0);
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=- Resultados -=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\nNo intervalo de 0 a 25,9 foram digitados " + ent0a25 + " números");
            Console.WriteLine("No intervalo de 26 a 50,9 foram digitados " + ent26a50 + " números");
            Console.WriteLine("No intervalo de 26 a 50,9 foram digitados " + ent51a75 + " números");
            Console.WriteLine("No intervalo de 26 a 50,9 foram digitados " + ent76a100 + " números");
            Console.WriteLine("\nMuito obrigado por participar");
            Console.ReadKey();
        }
    }
}
