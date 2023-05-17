using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace atv09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qntIns = 1, qntFem = 0, qntMas = 0, expF = 0, expH = 0, hEntreIdade = 0, somaIdH = 0, somaIdF = 0, menorIdF = int.MaxValue;
            string op;
            do
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=- Empresa de Recrutamento -=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("\t\t\tInscrição de número ["+qntIns+"]");
                Console.Write("-- Qual é o seu nome?\n>> ");
                string name = Console.ReadLine();
                Console.Write("\n-- Qual é o seu sexo?\n[1] Feminino\n[2] Masculino\n>> ");
                int sex = int.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é a sua idade?\n>> ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é o seu nivel de Escolaridade?\n[1] Ensino Fundamental\n[2] Ensino Médio\n[3] Ensino Superior\n[4] Pós-Graduação\n>> ");
                int escol = int.Parse(Console.ReadLine());
                Console.Write("\n-- Já possuí Experiencia na área?\n>> ");
                string expArea = Console.ReadLine();
                expArea = expArea.ToUpper();
                Console.Write("\n-- Deseja continuar cadastrar mais candidatos?\n>>");
                op = Console.ReadLine();
                op = op.ToUpper();

                //Avaliação
                if (sex == 1)//Mulheres
                {
                    qntFem++;
                    if (expArea == "SIM")
                    {
                        expF++;
                        somaIdF += idade;
                        if (idade <= menorIdF)
                            menorIdF = idade;
                    }
                }
                if (sex == 2)//Homens
                {
                    qntMas++;
                    if (expArea == "SIM")
                    {
                        expH++;
                        somaIdH += idade; 
                    }
                    if ((idade >= 35) && (idade <= 45))
                        hEntreIdade++;
                }
                switch (escol)
                {
                    case 1: //Ensino Fundamental

                        break;
                    case 2: //Ensino Médio

                        break;
                    case 3: //Ensino Superior

                        break;
                    case 4: //Pós-Graduação

                        break;
                }
                qntIns++;
                Console.Clear();
            } while (op != "NÃO");
            Console.WriteLine("\nA menor idade feminia é: "+menorIdF);
            Console.WriteLine("A porcetagem de Homens entre 35 a 45 anos é de: "+(100 * hEntreIdade)/qntMas+"%");
            Console.ReadKey();
        }
    }
}
