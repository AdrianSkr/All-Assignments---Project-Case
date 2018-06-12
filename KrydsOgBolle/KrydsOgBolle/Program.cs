using System;

namespace KrydsOgBolle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            static void Ramme()
            {
                int v = 5, h = 5;
                Console.SetCursorPosition(v, h);
                Console.Write("┌─────┬─────┬─────┐"); // lin 1
                Console.SetCursorPosition(v, h + 1);
                Console.Write("│ │ │ │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 2);
                Console.Write("│ 1 │ 2 │ 3 │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 3);
                Console.Write("│ │ │ │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 4);
                Console.Write("├─────┼─────┼─────┤"); // lin
                Console.SetCursorPosition(v, h + 5);
                Console.Write("│ │ │ │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 6);
                Console.Write("│ 4 │ 5 │ 6 │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 7);
                Console.Write("│ │ │ │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 8);
                Console.Write("├─────┼─────┼─────┤"); // lin
                Console.SetCursorPosition(v, h + 9);
                Console.Write("│ │ │ │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 10);
                Console.Write("│ 7 │ 8 │ 9 │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 11);
                Console.Write("│ │ │ │"); // lin 2 mellem
                Console.SetCursorPosition(v, h + 12);
                Console.Write("└─────┴─────┴─────┘"); // lin
            }
            static void Kryds(int v, int h)
            {
                Console.SetCursorPosition(v, h);
                Console.Write("X");
                Console.SetCursorPosition(v - 1, h + 1);
                Console.Write("X X");
                Console.SetCursorPosition(v, h + 2);
                Console.Write("X");
            }
            static void Bolle(int v, int h)
            {
                Console.SetCursorPosition(v, h);
                Console.Write("O");
                Console.SetCursorPosition(v - 1, h + 1);
                Console.Write("O O");
                Console.SetCursorPosition(v, h + 2);
                Console.Write("O");
            }
            
        }
    }
}
