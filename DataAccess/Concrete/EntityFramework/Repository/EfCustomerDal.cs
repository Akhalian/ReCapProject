﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalDbContext>, ICustomerDal 
    {
    }
}
