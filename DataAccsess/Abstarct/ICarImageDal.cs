using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess;
using Entities.Concrete;

namespace DataAccsess.Abstarct
{
    public interface ICarImageDal : IEntityRepository<CarImage>
    {
    }
}
