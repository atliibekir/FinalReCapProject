using Core.DataAccsess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstarct
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
