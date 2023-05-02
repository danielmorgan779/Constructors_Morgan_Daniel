using System;

namespace Constructors_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("Resident Evil", "M for Mature"); //Initializes values for both of are parameters

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}!"); // Prints to the console my favorite game and it's genre

            Game myOtherGame = new Game(); // A game object that wasn't initialized

            Console.WriteLine($"My second favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!"); // Prints to the console my second favorite game and it's rating
        }
    }
}
