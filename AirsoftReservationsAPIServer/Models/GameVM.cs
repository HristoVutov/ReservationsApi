using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirsoftReservationsAPIServer.Models
{
    public class GameVM
    {
        public DateTime GameStart { get; set; }
        public DateTime GameEnd { get; set; }
        public int Reservations { get; set; }
    }
}