using AirsoftReservationsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AirsoftReservationsAPIServer.Repository
{
    public class AccountRepository : BaseRepository
    {
        public User Authorize(string username, string password)
        {
            var acc = context.Users.Where(c => c.Name.Equals(username)).Select(c => new User
            {
                Name = c.Name,
                Email = c.Email
            }).FirstOrDefault();

            return acc;
        }
    }
}