using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoafisha.DataAccess.Models
{
    public class CinemaHall
    {
        public int CinemaHallId { get; set; }
        public string Name { get; set; }
        public int CinemaId { get; set; }
        public int SeatsCount { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual List<Session> Sessions { get; set; }
        public virtual List<Seat> Seats { get; set; }
    }
}
