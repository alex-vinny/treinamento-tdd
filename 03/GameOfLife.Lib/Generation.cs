namespace ConwaysGame
{
    public class Generation
    {
        Generation(int gen)
        {
            Gen = gen;
            Actual = 0;
        }

        public int Gen { get; }
        public int Actual { get; private set; }

        /// <summary>
        /// Generations star at 0.
        /// </summary>
        /// <param name="gen"></param>
        /// <returns>Instance</returns>
        public static Generation For(int gen)
        {
            return new Generation(gen);
        }

        public bool Next()
        {
            if (Actual == Gen)
                return false;

            Actual++;
            return true;
        }
    }
}
