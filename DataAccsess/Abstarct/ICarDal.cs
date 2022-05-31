using Core.DataAccsess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Abstarct
{
    
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter = null);
        
    }
}
