using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atv02_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool op = true;
            int count = 0;
            double somaIdade = 0, somaAltu = 0, somaPeso = 0, sexMas = 0, sexFem = 0, perSexM = 0, perSexF = 0, verdeLoiro = 0;
            for (int i = 0; op == true; i++)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=- Pesquisa -=-=-=-=-=-=-=-");
                Console.Write("-- Qual é o seu Sexo?\n[1] Masculino\n[2] Feminino\n>> ");
                int sex = int.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é a cor do seu Olho?\n[1] Azuis\n[2] Verdes\n[3] Castanho\n>> ");
                int olho = int.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é a cor do seu Cabelo?\n[1] Loiro\n[2] Castanho\n[3] Preto\n>> ");
                int cabelo = int.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é a sua Idade?\n>> ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é a sua Altura?\n>> ");
                double altura = double.Parse(Console.ReadLine());
                Console.Write("\n-- Qual é o seu Peso?\n>> ");
                double peso = double.Parse(Console.ReadLine());
                Console.WriteLine("\n-- Quer continuar? (S/N)");
                string escolha = Console.ReadLine();
                escolha = escolha.ToUpper();

                //Validações
                somaIdade += idade;
                somaAltu += altura;
                somaPeso += peso;
                count++;
                if (sex == 1)
                    sexMas++;
                if (sex == 2)
                    sexFem++;
                if((olho == 2)&&(cabelo == 1))
                    verdeLoiro++;
                if (escolha == "N")
                    op = false;
                Console.Clear();
            }
            if (sexMas != 0)
                perSexM = (sexMas*100) / count;
            if (sexFem != 0)
                perSexF = (sexFem*100) / count;

            Console.WriteLine("-=-=-=-=-=-=-=-=-=- Resultado da Pesquisa -=-=-=-=-=-=-=-");
            Console.WriteLine("\n-- A média da Idade de todos na pesquisa é de: "+somaIdade/count);
            Console.WriteLine("\n-- A média da Altura de todos na pesquisa é de: "+somaAltu/count);
            Console.WriteLine("\n-- A média do Peso de todos na pesquisa é de: "+somaPeso/count);
            Console.WriteLine("\n-- "+ perSexM +"% das pessoas da pesquisa são do sexo Masculino");
            Console.WriteLine("\n-- "+ perSexF +"% das pessoas da pesquisa são do sexo Feminino");
            Console.WriteLine("\n-- Possui "+ verdeLoiro+" pessoas com olhos Verdes e cabelos Loiros");
            Console.ReadKey();
        }
    }
}
