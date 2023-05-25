using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Atv10_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1, con0a2 = 0, con3a4 = 0, con5a6 = 0, con7a8 = 0, con9a10 = 0;
            double med0a2 = 0, med3a4 = 0, med5a6 = 0, med7a8 = 0, med9a10 = 0;
            Console.WriteLine("-=-=-=-=-=-=-=-=- Conceitos Finais -=-=-=-=-=-=-=-=-");
            do {
                Console.Write($"-- Qual foi a nota do {count}° aluno(a)\n>> ");
                double nota = double.Parse(Console.ReadLine());

                if ((nota >= 0.0) && (2.9 >= nota)){
                    con0a2++;
                    med0a2 += nota;
                }
                if ((nota >= 3.0) && (4.9 >= nota)){
                    con3a4++;
                    med3a4 += nota;
                }
                if ((nota >= 5.0) && (6.9 >= nota)){
                    con5a6++;
                    med5a6 += nota;
                }
                if ((nota >= 7.0) && (8.9 >= nota)){
                    con7a8++;
                    med7a8 += nota;
                }
                if ((nota >= 9.0) && (10.0 >= nota)){
                    con9a10++;
                    med9a10 += nota;
                }
                    count++;
            }while(count <=75);
            Console.Clear();
            Console.WriteLine("-=-=-=-=-=-=-=-=- Conceitos Finais -=-=-=-=-=-=-=-=-");
            Console.Write($"--Conceito: A\nQuantidade de Alunos(a): {con0a2}  |  Média: {med0a2/ con0a2}");
            Console.Write($"--Conceito: B\nQuantidade de Alunos(a): {con3a4}  |  Média: {med3a4/ con3a4}");
            Console.Write($"--Conceito: C\nQuantidade de Alunos(a): {con5a6}  |  Média: {med5a6/ con5a6}");
            Console.Write($"--Conceito: D\nQuantidade de Alunos(a): {con7a8}  |  Média: {med7a8/ con7a8}");
            Console.Write($"--Conceito: E\nQuantidade de Alunos(a): {con9a10}  |  Média: {med9a10/ con9a10}");
            Console.ReadKey();
        }
    }
}
