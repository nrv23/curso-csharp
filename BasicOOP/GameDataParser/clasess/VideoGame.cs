using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.clasess
{
    public class VideoGame
    {
        // Propiedades
        public string Title { get; init; }
        public  int ReleaseYear { get; init; }
        public decimal Rating { get; init; }

        // Constructor
        public VideoGame(string title, int releaseYear, decimal rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        // Método opcional para mostrar info
        public override string ToString()
        {
            return $"Title: {Title}, Release: {ReleaseYear}, Rating: {Rating}";
        }
    }
}

