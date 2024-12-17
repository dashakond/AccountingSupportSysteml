using AccountingSupportSystem.EF;
using AccountingSupportSystem.Entities;
using AccountingSupportSystem.Repositories.Interfaces;
using AccountingSupportSystem.Repositories.Impl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSupportSystem.Repositories.Impl
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public User GetByUsername(string username)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username);
        }
    }

}
