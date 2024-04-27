using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoafisha.DataAccess.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionId { get; set; }

        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }

        public virtual Session Session { get; set; }
        public int VisitorId { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
