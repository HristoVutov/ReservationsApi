using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirsoftReservationsAPIServer.Models.Reservation
{
    public class ReservationGet
    {
        public int Id { get; set; }
        public string ReservationBy { get; set; }
        public int NumberOfGuns { get; set; }
        public int NumberOfMagazines { get; set; }
        public int NumberOfPeople { get; set; }
        public int GameId { get; set; }
    }
}