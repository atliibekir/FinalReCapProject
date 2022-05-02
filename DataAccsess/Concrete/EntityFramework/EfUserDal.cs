using Core.DataAccsess.EntityRepository;
using DataAccsess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccsess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserId
                             select new UserDetailDto { UserId = u.Id, FirstName = u.FirstName, LastName = u.LastName, Email = u.Email,Password= u.Password, CompanyName = c.CompanyName};
                return result.ToList();
            }
        }
    }
}
