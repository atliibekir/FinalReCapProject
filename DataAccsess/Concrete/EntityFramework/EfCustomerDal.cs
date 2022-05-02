using Core.DataAccsess.EntityRepository;
using DataAccsess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
    }
}
