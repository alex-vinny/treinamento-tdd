using System;

namespace ConwaysGame
{
    public class Game : IDisposable
    {
        public Game(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public string Name { get; }
        public int Size { get; }

        public void Dispose()
        {
        }

        public void Init(Generation generations, params Cell[] initial_life)
        {
            var board = new Board(Name, Size);
            
            board.Seed(initial_life);
            board.Print(generations);

            while (generations.Next())
            {
                var evolve = new Evolve(initial_life);

                if (evolve.AllHaveDied)
                {
                    Console.WriteLine("No more life.");
                    break;
                }

                if (evolve.KeepStatic)
                {
                    Console.WriteLine("No movement.");
                    break;
                }

                //evolve.SeedBoard(board);
                //evolve.PrintBoard(generations);
            }
        }
    }
}
