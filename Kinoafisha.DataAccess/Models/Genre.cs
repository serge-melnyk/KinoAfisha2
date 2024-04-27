﻿namespace Kinoafisha.DataAccess.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual List<Film> Films { get; set; }
    }
}
