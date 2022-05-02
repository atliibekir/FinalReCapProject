using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess.EntityRepository;
using DataAccsess.Abstarct;
using DataAccsess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentACarContext>, ICarImageDal
    {
    }
}
