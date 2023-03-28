using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            int numero;

            do
            {
                Console.WriteLine("Escolha um número de 0 a 9 ou escreva 'sair':\n");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "0":
                        numero = 0;
                        Console.WriteLine("\nVocê escolheu o número 0\\n--------------------------------\n");
                        break;
                    case "1":
                        numero = 1;
                        Console.WriteLine("\nVocê escolheu o número 1n--------------------------------\n");
                        break;
                    case "2":
                        numero = 2;
                        Console.WriteLine("\nVocê escolheu o número 2\n----------------------------\n");
                        break;
                    case "3":
                        numero = 3;
                        Console.WriteLine("\nVocê escolheu o número 3\n---------------------------\n");
                        break;
                    case "4":
                        numero = 4;
                        Console.WriteLine("\nVocê escolheu o número 4\n-----------------------------\n");
                        break;
                    case "5":
                        numero = 5;
                        Console.WriteLine("\nVocê escolheu o número 5\n----------------------------\n");
                        break;
                    case "6":
                        numero = 6;
                        Console.WriteLine("\nVocê escolheu o número 6\n-----------------------------\n");
                        break;
                    case "7":
                        numero = 7;
                        Console.WriteLine("\nVocê escolheu o número 7\n-----------------------------\n");
                        break;
                    case "8":
                        numero = 8;
                        Console.WriteLine("\nVocê escolheu o número 8\n-----------------------------\n");
                        break;
                    case "9":
                        numero = 9;
                        Console.WriteLine("\nVocê escolheu o número 9\n-----------------------------\n");
                        break;
                    case "sair":
                        Console.WriteLine("\nVocê escolheu sair. Até a próxima!\n--------------------------------\n  ");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Escolha um número de 0 a 9 ou escreva 'sair'\n---------------------------\n");
                        numero = -1;
                        break;
                }
            } while (opcao.ToLower() != "sair");


        }
    }
}
