using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static   void Main(string[] args)
        {
            Game c = new Game
            {
                _name = "Chees",
                _numberOfPlayers = 2,
                _rating = 5.5f,
                _originCountry = "India"
            };

            Game f = new Game();
            f._name = "Footbol";
            f._numberOfPlayers = 20;
            f._rating = 5.5f;
            f._originCountry = "England";

            Game t = new Game();
            t._name = "Tennis";
            t._numberOfPlayers = 2;
            t._rating = 5.5f;
            t._originCountry = "France";

            Game b = new Game
            {
                _name = "Bowling",
                _numberOfPlayers = 4,
                _rating = 5.5f,
                _originCountry = "Egypt"
            };

            PrintGame(c);
            PrintGame(f);
            PrintGame(t);
            PrintGame(b);

        }

        private static void PrintGame(Game v)
        {
            Console.WriteLine(v);
            // Only for vew in ILDASM:
            int number = v.TellMeHowManyPlayers();
        }
    }
}
