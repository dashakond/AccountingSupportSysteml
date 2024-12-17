﻿using AccountingSupportSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSupportSystem.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
    }
}
