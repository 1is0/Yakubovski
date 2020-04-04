using System;

namespace Game2048
{
    class Program
    {
        static int Score = 0;
        static void Main(string[] args)
        {
            const int size = 4;
            Cell[,] array = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = new Cell();
                }
            }
            ConsoleKey Input = new ConsoleKey();
            GenerateNum(array, size);
            Show(array, size);
            while (isPossible(array, size))
            {
                Input = Console.ReadKey(true).Key;
                switch (Input)
                {
                    case ConsoleKey.LeftArrow:
                        moveLeft(array, size);
                        break;
                    case ConsoleKey.RightArrow:
                        moveRight(array, size);
                        break;
                    case ConsoleKey.UpArrow:
                        moveUp(array, size);
                        break;
                    case ConsoleKey.DownArrow:
                        moveDown(array, size);
                        break;
                    default:
                        Input = 0;
                        break;
                }
                if (Input == 0) break;
                GenerateNum(array, size);
                Show(array, size);
                refresh(array, size);
            }
            Console.WriteLine("GameOver. Press \"E\" to exit.");
            while (Console.ReadKey(true).Key != ConsoleKey.E) ;
        }
        static void Show(Cell[,] array, int size)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________");
            for (int i = 0; i < size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j].Value == 0)
                        Console.Write("    " + "\t");
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("    " + "\t");
                        Console.Write("\b\b\b\b\b\b\b");
                        Console.Write(Convert.ToString(array[i, j].Value) + "\t");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine("________________________________");
            }
            Console.WriteLine("Score: " + Score);
        }
        static bool isPossible(Cell[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j].Value == 0)
                        return true;
                    if (i < size - 1 && array[i, j].Value == array[i + 1, j].Value)
                        return true;
                    if (j < size - 1 && array[i, j].Value == array[i, j + 1].Value)
                        return true;
                    if (i > 0 && array[i, j].Value == array[i - 1, j].Value)
                        return true;
                    if (j > 0 && array[i, j].Value == array[i, j - 1].Value)
                        return true;
                }
            }
            return false;
        }
        static void moveRight(Cell[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 2; j >= 0; j--)
                {
                    if (array[i, j].Value != 0)
                    {
                        for (int k = j + 1; k < size; k++)
                        {
                            if (array[i, k].Value != 0)
                            {
                                if ((array[i, k].Value == array[i, j].Value) && array[i, k].IsUnited != true)
                                {
                                    array[i, k].Value *= 2;
                                    Score += array[i, k].Value;
                                    array[i, k].IsUnited = true;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k != j + 1)
                                {
                                    array[i, k - 1].Value = array[i, j].Value;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k == j + 1)
                                {
                                    break;
                                }
                            }
                            if (k == size - 1)
                            {
                                array[i, k].Value = array[i, j].Value;
                                array[i, j].Value = 0;
                                array[i, j].IsUnited = false;
                            }
                        }
                    }
                }
            }
        }
        static void moveDown(Cell[,] array, int size)
        {
            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j].Value != 0)
                    {
                        for (int k = i + 1; k < size; k++)
                        {
                            if (array[k, j].Value != 0)
                            {
                                if ((array[k, j].Value == array[i, j].Value) && array[k, j].IsUnited != true)
                                {
                                    array[k, j].Value *= 2;
                                    Score += array[k, j].Value;
                                    array[k, j].IsUnited = true;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k != i + 1)
                                {
                                    array[k - 1, j].Value = array[i, j].Value;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k == i + 1)
                                {
                                    break;
                                }
                            }
                            if (k == size - 1)
                            {
                                array[k, j].Value = array[i, j].Value;
                                array[i, j].Value = 0;
                                array[i, j].IsUnited = false;
                            }
                        }
                    }
                }
            }
        }
        static void moveLeft(Cell[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (array[i, j].Value != 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (array[i, k].Value != 0)
                            {
                                if ((array[i, k].Value == array[i, j].Value) && array[i, k].IsUnited != true)
                                {
                                    array[i, k].Value *= 2;
                                    Score += array[i, k].Value;
                                    array[i, k].IsUnited = true;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k != j - 1)
                                {
                                    array[i, k + 1].Value = array[i, j].Value;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k == j - 1)
                                {
                                    break;
                                }
                            }
                            if (k == 0)
                            {
                                array[i, k].Value = array[i, j].Value;
                                array[i, j].Value = 0;
                                array[i, j].IsUnited = false;
                            }
                        }
                    }
                }
            }
        }
        static void moveUp(Cell[,] array, int size)
        {
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j].Value != 0)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (array[k, j].Value != 0)
                            {
                                if ((array[k, j].Value == array[i, j].Value) && array[k, j].IsUnited != true)
                                {
                                    array[k, j].Value *= 2;
                                    Score += array[k, j].Value;
                                    array[k, j].IsUnited = true;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k != i - 1)
                                {
                                    array[k + 1, j].Value = array[i, j].Value;
                                    array[i, j].Value = 0;
                                    array[i, j].IsUnited = false;
                                    break;
                                }
                                else if (k == i - 1)
                                {
                                    break;
                                }
                            }
                            if (k == 0)
                            {
                                array[k, j].Value = array[i, j].Value;
                                array[i, j].Value = 0;
                                array[i, j].IsUnited = false;
                            }
                        }
                    }
                }
            }
        }
        static void refresh(Cell[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j].IsUnited = false;
                }
            }
        }
        static void GenerateNum(Cell[,] array, int size)
        {
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j].Value == 0) counter++;
                }
            }
            if (counter == 0) return;
            Random rnd = new Random();
            int rndValue = rnd.Next(1, counter);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j].Value == 0)
                    {
                        rndValue--;
                        if (rndValue == 0)
                        {
                            array[i, j].Value = 2;
                            return;
                        }
                    }
                }
            }
        }
    }
}
