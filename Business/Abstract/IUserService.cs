using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        //IDataResult<List<User>> GetAll();
        //IDataResult<User> GetById(int id);
        //IDataResult<List<UserDetailDto>> GetUserDetail();
        //IResult Add(User user);
        //IResult Delete(User user);
        //IResult Update(User user);
        //IDataResult<List<OperationClaim>> GetClaims(User user);
        //IDataResult<User> GetByMail(string email);


        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

    }
}
