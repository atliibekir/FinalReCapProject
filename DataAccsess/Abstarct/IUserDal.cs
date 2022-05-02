using Core.DataAccsess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstarct
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserDetailDto> GetUserDetail();
    }
}
