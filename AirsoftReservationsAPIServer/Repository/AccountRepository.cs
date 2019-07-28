using AirsoftReservationsAPI;
using AirsoftReservationsAPIServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AirsoftReservationsAPIServer.Repository
{
    public class AccountRepository : BaseRepository
    {
        public UserVM Authorize(string username, string password)
        {
            var acc = context.Users.Where(c => c.Name == username).Select(c => new UserVM
            {
                Username = c.Name,
                Email = c.Email
            }).FirstOrDefault();

            return acc;
        }
    }
}