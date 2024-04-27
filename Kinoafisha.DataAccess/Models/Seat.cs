using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoafisha.DataAccess.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
        public int CinemaHallId { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }
    }
}
