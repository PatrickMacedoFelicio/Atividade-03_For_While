using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=- Escolha a sua tabuada -=-=-=-=-");
            Console.Write("Qual será a tabuada efetuada?\n>> ");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Até que número você deseja efetuar a tabuada?\n>> ");
            int numEf = Convert.ToInt32(Console.ReadLine());

            //Efetuando a tabuadas
            Console.WriteLine("-=-=-=-=-=- Tabuada do " + tabuada + " -=-=-=-=-=-");
            for (int i = 0; i <= numEf; i++)
            {
                Console.WriteLine(tabuada+" X "+i+" = "+tabuada*i);
            }

            Console.ReadKey();
        }
    }
}
