using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoafisha.DataAccess.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public DateTime Date { get; set; }
        public int FilmId { get; set; }
        public int CinemaHallId { get; set; }
        public decimal Price { get; set; }

        public virtual Film Film { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
    }
}
