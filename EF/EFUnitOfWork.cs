using AccountingSupportSystem.EF;
using AccountingSupportSystem.Repositories.Impl;
using AccountingSupportSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSupportSystem.UnitOfWork
{


    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IUserRepository UserRepository { get; private set; }
        public IAdminRepository AdminRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            UserRepository = new UserRepository(context);
            AdminRepository = new AdminRepository(context);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
