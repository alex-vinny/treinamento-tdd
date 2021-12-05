namespace ConwaysGame
{
    public class Cell
    {
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Horizontal
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Vertical
        /// </summary>
        public int Y { get; }
    }
}
