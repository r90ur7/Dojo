using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Desafios.Jogo_Da_Velha
{
    internal class Case15
    {
        public Case15() { }
        static char[,] board = new char[3, 3]; // Tabuleiro do jogo
        static char currentPlayer = 'X'; // Jogador atual ('X' ou 'O')

        internal static void Start()
        {
            InitializeBoard();
            bool gameEnded = false;

            while (!gameEnded)
            {
                DrawBoard();
                Console.Write("\n-------------------------------------\n");
                Console.WriteLine("É a vez do jogador " + currentPlayer);
                Console.Write("\n-------------------------------------\n");
                Console.WriteLine("Digite a linha (0-2):");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a coluna (0-2):");
                int col = Convert.ToInt32(Console.ReadLine());

                if (IsValidMove(row, col))
                {
                    MakeMove(row, col);
                    gameEnded = CheckGameEnd();
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Movimento inválido! Tente novamente.");
                }
            }

            DrawBoard();
            Console.WriteLine("Fim de jogo!");
        }

        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidMove(int row, int col)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2)
            {
                return false;
            }

            if (board[row, col] != ' ')
            {
                return false;
            }

            return true;
        }

        static void MakeMove(int row, int col)
        {
            board[row, col] = currentPlayer;
        }

        static bool CheckGameEnd()
        {
            // Verificar linhas
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer)
                {
                    Console.WriteLine("Jogador " + currentPlayer + " venceu!");
                    return true;
                }
            }

            // Verificar colunas
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer)
                {
                    Console.WriteLine("Jogador " + currentPlayer + " venceu!");
                    return true;
                }
            }

            // Verificar diagonais
            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            {
                Console.WriteLine("Jogador " + currentPlayer + " venceu!");
                return true;
            }

            // Verificar empate
            bool isBoardFull = true;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                    {
                        isBoardFull = false;
                        break;
                    }
                }
                if (!isBoardFull)
                {
                    break;
                }
            }

            if (isBoardFull)
            {
                Console.WriteLine("Empate!");
                return true;
            }

            return false;
        }
    }

}
