using Core.DataAccsess.EntityRepository;
using DataAccsess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.DTOs;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                    join c in context.Customers on r.CustomerId equals c.CustomerId
                    join ca in context.Cars on r.CarId equals ca.Id
                    join b in context.Brands on ca.BrandId equals b.Id
                    join u in context.Users on c.UserId equals u.Id
                    select new RentalDetailDto
                        { Id = r.RentalId, BrandName = b.BrandName, FirstName = u.FirstName, LastName = u.LastName,RenDate = r.RenDate.ToString("d"),ReturnDate = r.ReturnDate.ToString("d")};
                return result.ToList();
            }
            
        }
    }
}
