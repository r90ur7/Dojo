using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;
using Dojo.Desafios.Jogo_Da_Velha;


namespace Dojo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            int numero;
            CultureInfo culturaSistema = CultureInfo.CurrentCulture;
            RegionInfo regiaoSistema = new RegionInfo(culturaSistema.Name);
            string simboloMoeda = regiaoSistema.CurrencySymbol;

            do
            {

                Console.WriteLine("---------------------------\n\nMENU DO DOJO\n\n---------------------------\n");
                Console.WriteLine("\nEscolha um número de 0 a 15 ou escreva 'sair':\n");
                Console.WriteLine("0)Sair:\n");
                Console.WriteLine("1)Soma:\n");
                Console.WriteLine("2)Conversão de metros para milímetros:\n");
                Console.WriteLine("3)Calcular Aumento:\n");
                Console.WriteLine("4)Calcular Desconto:\n");
                Console.WriteLine("6)Calcular IMC:\n");
                Console.WriteLine("9)Múltiplos de 3 entre 0 e 100:\n");
                Console.WriteLine("10)Fatoriais De 1 Até 10:\n");
                Console.WriteLine("11)Calcular o Imposto De Renda:\n");
                Console.WriteLine("12)Adivinhe o Número:\n");
                Console.Write("Resposta: ");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "0":
                        numero = 0;
                        Console.WriteLine("\nVocê Escolheu Sair. Até a Próxima!\n--------------------------------\n  ");
                        Console.Write("Presione Qualquer Tecla Para FSechar");
                        opcao = "sair";
                        Console.ReadKey();
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

                        if (Metrosbol == false)
                        {
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
                        Console.WriteLine("\n\n----------------------------\n\nVOCÊ ESCOLHEU O 3 - CALCULAR AUMENTO\n\n----------------------------\n");
                        Console.Write("\nDigite o Valor Inicial: ");
                        decimal Valor;
                        bool ValorInicial = decimal.TryParse(Console.ReadLine(), out Valor);
                        if (ValorInicial == false)
                        {
                            Console.WriteLine("Esse número não é válido.");
                        }
                        else
                        {
                            Console.Write("\nQuantos Porcento de aumento? ");
                            decimal Porcentagem;
                            bool PercentValid = decimal.TryParse(Console.ReadLine(), out Porcentagem);
                            if (PercentValid == false)
                            {
                                Console.WriteLine("Esse número não é válido.");
                            }
                            else
                            {
                                decimal Aumento = (Porcentagem / 100) * Valor;
                                decimal ValorFinal = (Valor + Aumento);
                                decimal format = Decimal.Round(ValorFinal, 2);
                                Console.Write($"\n*****************************\n\nRESULTADO!!!!!\n\n O Valor do Aumento é {simboloMoeda} {Aumento} e Valor Final é {simboloMoeda} {format}\n\n*****************************\n");
                            }
                        }
                        break;
                    case "4":
                        numero = 4;
                        Console.WriteLine("\n\n----------------------------\n\nVOCÊ ESCOLHEU O 4 - CALCULAR DESCONTO\n\n----------------------------\n");
                        Console.Write("\nDigite o Valor Inicial: ");
                        decimal ValorDESconto;
                        bool ValorDescInicial = decimal.TryParse(Console.ReadLine(), out ValorDESconto);
                        if (ValorDescInicial == false)
                        {
                            Console.WriteLine("Esse número não é válido.");
                        }
                        else
                        {
                            Console.Write("\nQuantos Porcento de aumento? ");
                            decimal Porcentagem;
                            bool PercentValid = decimal.TryParse(Console.ReadLine(), out Porcentagem);
                            if (PercentValid == false)
                            {
                                Console.WriteLine("Esse número não é válido.");
                            }
                            else
                            {
                                decimal Desconto = (Porcentagem / 100) * ValorDESconto;
                                decimal ValorDescFinal = (ValorDESconto - Desconto);
                                decimal formatDEsconto = Decimal.Round(ValorDescFinal, 2);
                                Console.Write($"\n*****************************\n\nRESULTADO!!!!!\n\n O Valor do Desconto é {simboloMoeda} {Desconto} e Valor Final é {simboloMoeda} {formatDEsconto}\n\n*****************************\n");
                            }
                        }
                        break;

                    case "5":
                        numero = 5;
                        Console.WriteLine("\nVocê escolheu o número 5\n----------------------------\n");
                        break;
                    case "6":
                        numero = 6;
                        string Consulta;
                        Console.WriteLine("\n\n----------------------------\n\nVOCÊ ESCOLHEU O 6 - CALCULAR O IMC\n\n----------------------------\n");
                        Console.Write("\nDigite Seu Peso: ");
                        float Peso;
                        bool PesoValid = float.TryParse(Console.ReadLine(), out Peso);
                        if (PesoValid == false)
                        {
                            Console.WriteLine("Esse Peso não é Válido.");
                        }
                        else
                        {
                            Console.Write("\nDigite Sua Altura: ");
                            float Altura;
                            bool AlturaValid = float.TryParse(Console.ReadLine(), out Altura);
                            if (AlturaValid == false)
                            {
                                Console.WriteLine("Essa Altura não é Válida.");
                            }
                            else
                            {
                                double IMC = Peso / Math.Pow(Altura, 2);
                                if (IMC < 18.5)
                                {
                                    Consulta = "Abaixo Do Peso";
                                }
                                else if (IMC >= 18.5 && IMC <= 29.9)
                                {
                                    Consulta = "No Peso Ideal";
                                }
                                else if (IMC >= 30 && IMC <= 34.9)
                                {
                                    Consulta = "Na Obesidade grau 1";
                                }
                                else if (IMC >= 35 && IMC <= 39.9)
                                {
                                    Consulta = "Na Obesidade grau 2";
                                }
                                else
                                {
                                    Consulta = "Obesidade grau 3";
                                }
                                Console.Write($"\n*****************************\n\nRESULTADO!!!!!\n\nVocê Está {Consulta}\n\nO IMC Do Peso {Peso} Na Altura {Altura:F2} é {IMC:F2}\n\n*****************************\n");
                            }
                        }
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
                        Console.WriteLine("\n\n----------------------------\n\nVocê escolheu o número 9 - MÚLTIPLOS DE 3 ENTRE 0 E 100!!!\n\n----------------------------\n");
                        Console.Write("Resultado!!!\n\n*****************************\n\nOs Multiplos São: ");
                        var Count = 0;
                        while (Count < 100)
                        {
                            Count = Count + 1;
                            if (Count % 3 == 0)
                            {
                                if (Count == 99)
                                {
                                    Console.WriteLine($"{Count} \n\n*****************************\n");
                                }
                                else
                                {
                                    Console.Write($"{Count},");
                                }
                            }
                        }
                        break;
                    case "10":
                        numero = 10;
                        List<int> Fatoriais = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        var table = new ConsoleTable("Fatoriais");
                        Console.WriteLine("\n\n----------------------------\n\nVocê escolheu o número 10 - FATORIAIS DE 1 ATÉ 10!!!\n\n----------------------------\n");
                        foreach (var Fatorial in Fatoriais)
                        {
                            int CalcFatorial = CalcularFatorial(Fatorial);
                            table.AddRow($" De {Fatorial} : {CalcFatorial}");
                        }
                        table.Write();

                        int CalcularFatorial(int n)
                        {
                            if (n == 0 || n == 1)
                            {
                                return 1;
                            }
                            else
                            {
                                return n * CalcularFatorial(n - 1);
                            }
                        }
                        break;
                    case "11":
                        numero = 11;
                        Console.WriteLine("\n\n----------------------------\n\nVocê escolheu o número 11 - CALCULO DE IMPOSTO DE RENDA!!!\n\n----------------------------\n");
                        Console.Write($"\nDigite Sua Renda Bruta: {simboloMoeda} ");
                        double rendaBruta;
                        bool rendaBrutaValid = double.TryParse(Console.ReadLine(), out rendaBruta);
                        if (rendaBrutaValid == false)
                        {
                            Console.WriteLine("Renda Inválida.");
                        }
                        else
                        {

                            Console.WriteLine("\n\nDigite suas deduções permitidas (digite 0 para parar): ");
                            List<double> deducoes = new List<double>();
                            double deducao;
                            bool deducaoValid = double.TryParse(Console.ReadLine(), out deducao);
                            while (deducao != 0)
                            {
                                if (deducaoValid == false)
                                {
                                    Console.WriteLine("\n\nDedução inválida Inválida.\n");
                                }
                                deducoes.Add(deducao);
                                deducao = Convert.ToDouble(Console.ReadLine());
                            }
                            double deducaoSoma = 0;

                            foreach (var deducaoid in deducoes)
                            {
                                deducaoSoma = deducaoSoma + deducaoid;
                            }
                            double rendaLiquida = rendaBruta - deducaoSoma;
                            Console.WriteLine($"Sua Renda Liquida {simboloMoeda} {rendaLiquida}");

                            double aliquota = 0;

                            if (rendaLiquida <= 1903.98)
                            {
                                Console.WriteLine($"isento de imposto de renda");
                            }
                            else if (rendaLiquida <= 2826.65)
                            {
                                aliquota = (7.5 / 100);
                            }
                            else if (rendaLiquida <= 3751.05)
                            {
                                aliquota = (15 / 100);
                            }
                            else if (rendaLiquida <= 4664.68)
                            {
                                aliquota = (22.5 / 100);
                            }
                            else
                            {
                                aliquota = (27.5 / 100);
                            }
                            double Imposto = rendaLiquida * aliquota;
                            Console.WriteLine($"Seu imposto de Renda é {Imposto}");
                        }
                        break;

                    case "12":
                        numero = 12;
                        Console.WriteLine("\n\n----------------------------\n\nVocê escolheu o número 12 - Advinhar Número!!!\n\n----------------------------\n");
                        Console.Write($"\nEscolha o numero mínimo para advinhar: ");

                        int Minnumber;
                        bool MinnumberValid = int.TryParse(Console.ReadLine(), out Minnumber);
                        if (MinnumberValid == false)
                        {
                            Console.WriteLine("número Inválido.");
                            break;
                        }

                        Console.Write($"\nEscolha o numero máximo para advinhar: ");
                        int Maxnumber;
                        bool MaxnumberValid = int.TryParse(Console.ReadLine(), out Maxnumber);
                        if (MaxnumberValid == false)
                        {
                            Console.WriteLine("número Inválido.");
                            break;
                        }

                        Random Advinhacao = new Random();

                        int numeroRadom = Advinhacao.Next(Minnumber, Maxnumber + 1);
                        int adivinha = 0;
                        while (adivinha != numeroRadom)
                        {
                            Console.Write($"\nAgora tente Adivinhar o numero :>\nResposta:");
                            bool adivinhaValid = int.TryParse(Console.ReadLine(), out adivinha);
                            if (adivinhaValid == false)
                            {
                                Console.WriteLine("número Inválido.");
                            }
                            if (adivinha > numeroRadom)
                            {
                                Console.WriteLine($"\n*****O numero é menor que isso :p *****\n\n");
                                continue;
                            }
                            else if (adivinha < numeroRadom)
                            {
                                Console.WriteLine($"\n*****O numero é maior que isso :^ *****\n\n");
                                continue;
                            }
                        }
                        if (adivinha == numeroRadom)
                        {
                            Console.WriteLine($"\n\n **********PARABENS!!!!!********** \n\nO número era {numeroRadom} Você Acertou :>\n");
                            break;
                        }
                        break;

                    case "13":
                        numero = 13;
                        Console.WriteLine("\nVocê escolheu o número 13\n-----------------------------\n");
                        break;
                    case "14":
                        numero = 14;
                        Console.WriteLine("\nVocê escolheu o número 14\n-----------------------------\n");
                        break;
                    case "15":
                        numero = 15;
                        Console.WriteLine("\n\n----------------------------\n\nVocê escolheu o número 15 - Jogo Da Velha!!!\n\n----------------------------\n");
                        Case15.Start();
                        break;
                    case "sair":
                        Console.WriteLine("\nVocê escolheu sair. Até a próxima!\n--------------------------------\n  ");
                        break;
                    default:
                        numero = -1;
                        Console.WriteLine("\nOpção inválida. Escolha um número de 0 a 9 ou escreva 'sair'\n---------------------------\n");
                        break;
                }
            } while (opcao.ToLower() != "sair");
        }
    }
}
