using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pedro = 1.50, lucas = 1.10;
            int dataIg = 0, count;
            for (count = 0; lucas < pedro; count++)
            {
                pedro = pedro+0.02;
                lucas = lucas+0.03;
                Console.WriteLine("Pedro: "+pedro+"\nLucas: "+ lucas);
                if (pedro == lucas)
                    dataIg = count;
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(">> Pedro e Lucas terão a mesma altura em "+dataIg+" anos.");
            Console.WriteLine(">> Lucas passara Pedro em "+ count + " anos");
            Console.ReadKey();
        }
    }
}
