namespace Kinoafisha.DataAccess.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public decimal Duration { get; set; }

        public int DirectorId { get; set; }
        public virtual Person Director { get; set; }

        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

        public virtual List<Genre> Genres { get; set; }
        public virtual List<Country> Countries { get; set; }
        public virtual List<Person> Actors { get; set; }
        public virtual List<FilmRole> FilmRoles { get; set; }

    }
}
