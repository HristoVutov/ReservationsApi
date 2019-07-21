using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirsoftReservationsAPIServer.Models
{
    public class DayVM
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public List<GameVM> Games { get; set; }
    }
}