using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        static char move = '-';

        private static void Main(string[] args)
        {
            bool player1 = true;
            bool gameEnded = false;

            Console.Write("Player1 choose your name: ");
            var p1 = Console.ReadLine();
            Console.Write("Player2 choose your name: ");
            var p2 = Console.ReadLine();
            InitBoard();

            while (!gameEnded)
            {
                DisplayBoard();
                if (IsTie())
                {
                    gameEnded = true;
                    Console.WriteLine("\nIts a tie!\n");
                    Console.WriteLine("Press any key to exit..");
                    Console.ReadKey();
                }

                if (PlayerHasWon())
                {
                    if (player1 == false)
                    {
                        gameEnded = true;
                        Console.WriteLine("\n" + p1 + " WON!\n");
                        Console.WriteLine("Press any key to exit..");
                        Console.ReadKey();
                    }
                    else
                    {
                        gameEnded = true;
                        Console.WriteLine("\n" + p2 + " WON!\n");
                        Console.WriteLine("Press any key to exit..");
                        Console.ReadKey();
                    }
                }

                if (player1)
                {
                    Console.Write(p1 + " players turn (x): ");
                }
                else
                {
                    Console.Write(p2 + " players turn (y): ");
                }

                if (player1)
                {
                    move = 'x';
                    player1 = false;
                }
                else
                {
                    move = 'o';
                    player1 = true;
                }

                int row = 0;
                int col = 0;

                while (!gameEnded)
                {
                    Console.Write("Enter row number (0, 1, 2): ");
                    row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter column number (0, 1, 2): ");
                    col = Convert.ToInt32(Console.ReadLine());

                    if (row > 2 || row < 0 || col < 0 || col > 2)
                    {
                        Console.Write("This position is out of board, try again!");
                    }
                    else if (board[row, col] != '-')
                    {
                        Console.Write("This position is already taken\n");
                    }
                    else
                    {
                        break;
                    }
                }
                board[row, col] = move;
            }
        }

        public static bool IsTie()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool PlayerHasWon()
        {
            if (board[0, 0] == 'x' && board[0, 1] == 'x' && board[0, 2] == 'x' ||
                board[1, 0] == 'x' && board[1, 1] == 'x' && board[1, 2] == 'x' ||
                board[2, 0] == 'x' && board[2, 1] == 'x' && board[2, 2] == 'x' ||

                board[0, 0] == 'x' && board[1, 0] == 'x' && board[2, 0] == 'x' ||
                board[0, 1] == 'x' && board[1, 1] == 'x' && board[2, 1] == 'x' ||
                board[0, 2] == 'x' && board[1, 2] == 'x' && board[2, 2] == 'x' ||

                board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x' ||
                board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x')
            {
                return true;
            }
            else if (board[0, 0] == 'o' && board[0, 1] == 'o' && board[0, 2] == 'o' ||
                board[1, 0] == 'o' && board[1, 1] == 'o' && board[1, 2] == 'o' ||
                board[2, 0] == 'o' && board[2, 1] == 'o' && board[2, 2] == 'o' ||

                board[0, 0] == 'o' && board[1, 0] == 'o' && board[2, 0] == 'o' ||
                board[0, 1] == 'o' && board[1, 1] == 'o' && board[2, 1] == 'o' ||
                board[0, 2] == 'o' && board[1, 2] == 'o' && board[2, 2] == 'o' ||

                board[0, 0] == 'o' && board[1, 1] == 'o' && board[2, 2] == 'o' ||
                board[0, 2] == 'o' && board[1, 1] == 'o' && board[2, 0] == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = '-';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("      0     1     2");
            Console.WriteLine("    -----+-----+-----");
            Console.WriteLine("  0   " + board[0, 0] + "  |  " + board[0, 1] + "  |  " + board[0, 2]);
            Console.WriteLine("    -----+-----+-----");
            Console.WriteLine("  1   " + board[1, 0] + "  |  " + board[1, 1] + "  |  " + board[1, 2]);
            Console.WriteLine("    -----+-----+-----");
            Console.WriteLine("  2   " + board[2, 0] + "  |  " + board[2, 1] + "  |  " + board[2, 2]);
            Console.WriteLine("    -----+-----+-----");
        }
    }
}
