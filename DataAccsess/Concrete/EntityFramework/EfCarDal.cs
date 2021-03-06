using Core.DataAccsess.EntityRepository;
using DataAccsess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join co in context.Colors
                        on c.ColorId equals co.Id
                    join ci in context.CarImages
                        on c.Id equals ci.CarId

                    select new CarDetailDto
                    {
                        CarId = c.Id, CarName = c.CarName, BrandName = b.BrandName,
                        ColorName = co.ColorName, DailyPrice = c.DailyPrice, ImagePath = ci.ImagePath,
                        ModelYear = c.ModelYear, BrandId = b.Id, ColorId = co.Id,Description = c.Description

                    };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }

    }
}

