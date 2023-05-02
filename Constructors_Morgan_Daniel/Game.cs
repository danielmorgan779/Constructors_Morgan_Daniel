using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Morgan_Daniel
{
    class Game
    {

        public string title, genre; //Two public strings for the game title and game genre

        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") //Public constructor
        {
            title = titleParam; //With two public parameters
            genre = genreParam; // Title parameter and genre Parameter
        }

    }
}
