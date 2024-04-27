namespace Kinoafisha.DataAccess.Models
{
    public class FilmRole
    {
        public int FilmRoleId { get; set; }
        public string Name { get; set; }

        public virtual List<Person> People { get; set; }
    }
}
