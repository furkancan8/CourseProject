using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserVerifyService
    {
        Task<IResult >Add(UserVerify userVerify);
        IResult Update(UserVerify userVerify);
        IResult Delete(int userVerifyId);
        IDataResult<List<UserVerify>> GetAll();
        IDataResult<UserVerify> GetById(int userVerifyId);
        IDataResult<UserVerify> GetByMail(string userMail);
    }
}
