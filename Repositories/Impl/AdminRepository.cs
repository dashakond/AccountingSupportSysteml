using AccountingSupportSystem.EF;
using AccountingSupportSystem.Entities;
using AccountingSupportSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSupportSystem.Repositories.Impl
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(ApplicationDbContext context) : base(context) { }

        public Admin GetAdminByUsername(string username)
        {
            return _context.Admins.SingleOrDefault(a => a.Username == username);
        }
    }
}

