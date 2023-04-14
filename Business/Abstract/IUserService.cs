using Core.Entities.Concrate;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<OperationClaim>> GetUserClaims(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int id);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        IDataResult<User> GetByMail(string email);
        void SendMailOfChangePassword(string email);
    }
}
