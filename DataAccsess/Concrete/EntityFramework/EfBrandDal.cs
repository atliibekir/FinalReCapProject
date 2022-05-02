using Core.DataAccsess.EntityRepository;
using DataAccsess.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
       
       
    }
}
