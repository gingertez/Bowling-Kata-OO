using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new BowlingGame(args[0]);
            try
            {
                Console.WriteLine($"Score is {game.Score()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating score: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
