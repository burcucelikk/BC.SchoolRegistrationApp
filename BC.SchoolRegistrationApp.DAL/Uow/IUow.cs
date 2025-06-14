﻿using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Uow
{
    public interface IUow
    {
        void SaveChanges();
        IGenericRepository<T> GetRepository<T>() where T: class, IEntity;
    }
}
