using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLEditer
{
    class Ticket
    {
        public Ticket(int id, double total, DateTime day)
        {
            Id = id;
            Total = total;
            Day = day;
        }
        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime Day { get; set; }
    }
}
