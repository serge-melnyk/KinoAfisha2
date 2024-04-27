namespace Kinoafisha.DataAccess.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual List<Film> Films { get; set; }

        public virtual List<Person> People { get; set; }
        public virtual List<Cinema> Cinemas { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}
