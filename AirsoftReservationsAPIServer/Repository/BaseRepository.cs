using AirsoftReservationsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirsoftReservationsAPIServer.Repository
{
    public class BaseRepository
    {
        public ReservationsDatabaseEntities context;

        public BaseRepository()
        {
            context = new ReservationsDatabaseEntities();
        }
    }
}