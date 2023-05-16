using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seq1 = 1, seqAnterior = 0, resul = 0;
            Console.WriteLine("-=-=-=-=-=-=-=-=- Sequência de Fibonacci -=-=-=-=-=-=-=-=-");
            Console.Write("Digite um número que a sequencia chegue até ela\n>> ");
            int numDigitado = int.Parse(Console.ReadLine());

            while (resul <= numDigitado)
            {
                resul = seq1 + seqAnterior;
                seqAnterior = seq1;
                seq1 = resul;
                Console.Write(resul+", ");
            }
            Console.ReadKey();
        }
    }
}
