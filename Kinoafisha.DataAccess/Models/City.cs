
namespace Kinoafisha.DataAccess.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
