using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conway's Game of Life - Rosetta Code");
            Console.WriteLine();

            using (var game = new Game("blinker", 3)) // 3 x 3 square
            {
                game.Init(
                    Generation.For(2),
                    new[]
                    {
                        ///       X  Y
                        new Cell(0, 1),
                        new Cell(1, 1),
                        new Cell(2, 1)
                    });
            }


            Console.WriteLine();
            Console.WriteLine("Press enter to finish!!!");
            Console.ReadLine();
        }
    }
}
