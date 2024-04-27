using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoafisha.DataAccess.Models
{
    public class Cinema
    {
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public string Description { get; set; }
        public int ImageId { get; set; }

        public virtual Image Image { get; set; }

        public virtual List<Session> Sessions { get; set; }

        public virtual List<CinemaHall> CinemaHalls { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

    }
}
