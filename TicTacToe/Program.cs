using System;

namespace TicTacToe
{
    class Program
    {
        static int SIZE_X = 5;
        static int SIZE_Y = 5;
        static char [,] field = new char[SIZE_Y, SIZE_X];

        static int WIN_SIZE = 4;
        static int winLineCount = 0;

        static char PLAYER_DOT = 'X';
        static char AI_DOT = '0';
        static char EMPTY_DOT = '.';

        static Random rnd = new Random();

        private static void InitField()
        {
            for (int y = 0; y < SIZE_Y; y++)
            {
                for (int x = 0; x < SIZE_X; x++)
                {
                    field[y, x] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine(new String('-',SIZE_Y * 2 + 1));
            for (int y = 0; y < SIZE_Y; y++)
            {
                Console.Write("|");
                for (int x = 0; x < SIZE_X; x++)
                {
                    Console.Write(field[y,x] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('-', SIZE_Y * 2 + 1));

        }

        private static void SetSymbol(int y, int x, char s)
        {
            field[y, x] = s;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y)
            {
                return false;
            }
            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int y = 0; y < SIZE_Y; y++)
            {
                for (int x = 0; x < SIZE_X; x++)
                {
                    if (field[y,x] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine())-1;
                y = Int32.Parse(Console.ReadLine())-1;
            } while (!IsCellValid(y,x));
            SetSymbol(y, x, PLAYER_DOT);
        }

        private static void AiStep()
        {
            int x;
            int y;
            do
            {
                x = rnd.Next(0,SIZE_X);
                y = rnd.Next(0,SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSymbol(y, x, AI_DOT);
        }

        private static bool CheckWin(char s)
        {
            winLineCount = 0;
            
            for (int y = 0; y < SIZE_Y - 1; y++)
            {
                for (int x = 0; x < SIZE_X - 1; x++)
                {
                    if (field[y, x] == s)
                    {
                        winLineCount++;
                        if (winLineCount == WIN_SIZE)
                            return true;                            
                    }
                    else
                        winLineCount = 0;
                }
            }
            
            for (int x = 0; x < SIZE_X; x++)
            {
                for (int y = 0; y < SIZE_Y; y++)
                {
                    if (field[y, x] == s)
                    {
                        winLineCount++;
                        if (winLineCount == WIN_SIZE)
                            return true;
                    }
                    else
                        winLineCount = 0;
                }
            }

            for (int y = 0; y < SIZE_Y; y++)
            {

                if (field[y, y] == s)
                {
                    winLineCount++;
                    if (winLineCount == WIN_SIZE)
                        return true;
                }
                else
                    winLineCount = 0;
            }

            for (int y = SIZE_Y - 1; y >= 0; y--)
            {
                if (field[y, SIZE_X - y - 1] == s)
                {
                    winLineCount++;
                    if (winLineCount == WIN_SIZE)
                        return true;
                }
                else
                    winLineCount = 0;
            }
            return false;
        }

        static void Main(string[] args)
        {
            InitField();
            PrintField();

            while (true)
            {
                PlayerStep();
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }

                AiStep();
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("Ai Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }
    }
}
