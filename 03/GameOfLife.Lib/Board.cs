using System;

namespace ConwaysGame
{
    public class Board
    {
        private readonly bool[][] board;
        
        public string Name { get; }
        public int Size { get; }

        /// <summary>
        /// Square size X size
        /// </summary>
        /// <param name="size"></param>
        public Board(string name, int size)
        {
            Name = name;
            Size = size;

            board = new bool[Size][];
            for (int i = 0; i < Size; i++)
            {
                board[i] = new bool[Size];
                for (int j = 0; j < Size; j++)
                    board[i][j] = false;
            }
        }

        /// <summary>
        /// X axis
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool[] this[int index]
        {
            get { return board[index]; }
        }

        public void Print(Generation generation)
        {
            Console.WriteLine($"{Name}: generation: {generation.Actual}");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{ (board[i][j] ? '#' : '.') } ");
                }
                Console.WriteLine();
            }
        }
    }
}
