using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IDataResult<List<UserDetailDto>> GetUserDetail();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
