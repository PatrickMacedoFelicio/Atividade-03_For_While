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
            int qntIns = 1, qntFem = 0, qntMas = 0, expF = 0, expH = 0, hEntreIdade = 0, smIdH = 0, smIdF = 0, menorIdF = 0;
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
                Console.Write("-- Já possuí Experiencia na área?\n>> ");
                string expArea = Console.ReadLine();
                expArea.ToUpper();
                Console.Write("\n-- Deseja continuar cadastrar mais candidatos?\n>>");
                op = Console.ReadLine();
                op.ToUpper();

                //Avaliação
                if (sex == 1)//Mulheres
                {
                    
                    qntFem++;
                    if (expArea == "SIM")
                    {
                        expF++;
                        smIdF += idade;
                        if (idade <= menorIdF)
                            menorIdF += idade;
                    }
                }
                if (sex == 2)//Homens
                {
                    qntMas++;
                    if (expArea == "SIM")
                    {
                        expH++;
                        smIdH += idade;
                        if ((idade >= 35) && (idade <= 45))
                            hEntreIdade++;
                    }
                }
                qntIns++;
                Console.Clear();
            } while (op != "não");
            Console.WriteLine("\nA menor idade feminia é: "+menorIdF);
            Console.ReadKey();
        }
    }
}
