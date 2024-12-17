using AccountingSupportSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSupportSystem.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        Admin GetAdminByUsername(string username);
    }
}
