using System.Linq;

namespace ConwaysGame
{
    public static class BoardExtensions
    {
        public static void Seed(this Board board, params Cell[] initial_life)
        {
            // Seed only if there are some cells
            if (initial_life.Any())
            {
                foreach (var point in initial_life.OrderBy(p => p.X).ThenBy(p => p.Y))
                {
                    board[point.X][point.Y] = true;
                }
            }
        }
    }
}
