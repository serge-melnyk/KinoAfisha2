namespace Kinoafisha.DataAccess.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<FilmRole> FilmRoles { get; set; }

        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

        public virtual List<Film> Films { get; set; }
    }
}
