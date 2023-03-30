﻿using System;
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
                Console.WriteLine("Escolha um número de 0 a 9 ou escreva 'sair':\n---------------------------\n");
                Console.WriteLine("0)Sair:\n");
                Console.WriteLine("1)Soma:\n");
                Console.WriteLine("2)Conversão de metros para milímetros:\n");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "0":
                        numero = 0;
                        Console.WriteLine("\nVocê escolheu sair. Até a próxima!\n--------------------------------\n  ");
                        opcao = "sair";
                        break;

                    case "1":
                        numero = 1;
                        Console.WriteLine("\nVocê escolheu o número 1 - Soma \n--------------------------------\n");
                        Console.WriteLine("Escolha o primeiro valor: ");
                        float v1;
                        bool valor1 = float.TryParse(Console.ReadLine(), out v1);
                        Console.WriteLine("Escolha o segundo valor: ");
                        float v2;
                        bool valor2 = float.TryParse(Console.ReadLine(), out v2);
                        if (valor1 == false)
                        {
                            Console.WriteLine("Esse número não é válido.");
                            break;
                        }
                        if (valor2 == false)
                        {
                            Console.WriteLine("Esse número não é válido.");
                            break;
                        }
                        else
                        {
                            var soma = v1 + v2;
                            Console.WriteLine("O resultado da soma é " + $"{soma}");
                        }
                        break;

                    case "2":
                        numero = 2;
                        Console.WriteLine("\nVocê escolheu o 2 - Conversão de metros para milímetros\n----------------------------\n");
                        Console.WriteLine("\nEscolha um Valor Em Metros \n----------------------------\n");
                        float Metros;
                        bool Metrosbol = float.TryParse(Console.ReadLine(), out Metros);
                        float mm = Metros * 1000;
                        
                        if(Metrosbol == false) {
                            Console.WriteLine("Esse número não é válido.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"A Quantidade {Metros} em milimetros é  {mm}");
                        }
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
