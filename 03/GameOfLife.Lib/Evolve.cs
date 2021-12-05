using System;

namespace ConwaysGame
{
    /// <summary>
    /// TODO
    /// </summary>
    public class Evolve
    {
        public Evolve(Cell[] initial_life)
        {
        }

        public bool AllHaveDied { get; private set; }
        public bool KeepStatic { get; private set; }

        public void SeedBoard(Board board)
        {
            throw new NotImplementedException();
        }

        public void PrintBoard(Generation generations)
        {
            throw new NotImplementedException();
        }
    }
}
