using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv10_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            double irpf = 0, inss = 0, irTotal = 0, pagTotal = 0; 
            do{
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- Folha de pagamento -=-=-=-=-=-=-=-=-=-");
                Console.Write("-- Digite o salário do funcionário:\n>> ");
                double sal = double.Parse(Console.ReadLine());

                //INSS
                if(sal <= 1556.94){ 
                    pagTotal += sal;
                    inss = sal * 0.08;
                    sal = sal - inss;
                }
                if ((sal >= 1556.95) && (sal <= 2594.92)){
                    pagTotal += sal;
                    inss = sal * 0.09;
                    sal = sal - inss;
                }
                if ((sal >= 2594.93) && (sal <= 5189.92)){
                    pagTotal += sal;
                    inss = sal * 0.11;
                    sal = sal - inss;
                }

                //IRPF - Já com desconto do INSS
                //(Salario * percentual de alíquota) - valor a ser deduzido
                if ((sal >= 1903.99) && (sal <= 2826.65)){
                    irpf = (sal * 0.075) - 142.80;
                    irTotal += irpf;
                }
                if ((sal >= 2826.66) && (sal <= 3751.05)){
                    irpf = (sal * 0.15) - 354.80;
                    irTotal += irpf;
                }
                if ((sal >= 3751.06) && (sal <= 4664.68)){
                    irpf = (sal * 0.225) - 636.13;
                    irTotal += irpf;
                }
                if (sal > 4664.68){
                    irpf = (sal * 0.275) - 869.36;
                    irTotal += irpf;
                }

                Console.WriteLine($"\n==- O sálario líquido do funcionário é de: R$ {sal}\n==- INSS: R$ {inss}\n==- Imposto de Renda: R$ {irpf} | Total ao ano: R$ {irpf*12}");
                Console.Write("\n-- Deseja continuar? (S/N)\n>> ");
                op = Console.ReadLine();
                op = op.ToUpper();
                Console.Clear();
            }while (op != "N");
            Console.Clear();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- Folha de pagamento -=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"\n==- O valor total da folha de pagamento da empresa será: R$ {pagTotal}");
            Console.WriteLine($"==- O valor total do imposto de Renda: R$ {irTotal}");
            Console.ReadKey();
        }
    }
}
