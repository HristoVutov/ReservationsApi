using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirsoftReservationsAPIServer.Models
{
    public class ReservationVM
    {
        public int Id { get; set; }
        public int ReservationBy { get; set; }
        public int NumberOfGuns { get; set; }
        public int NumberOfMagazines { get; set; }
        public int NumberOfPeople { get; set; }
        public int GameId { get; set; }
    }
}