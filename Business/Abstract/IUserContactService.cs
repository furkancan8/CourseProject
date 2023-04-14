using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserContactService
    {
        IResult Add(UserContact contact);
        IResult Update(UserContact contact);
        IResult Delete(int contactId);
        IDataResult<List<UserContact>> GetAll();
        IDataResult<UserContact> GetById(int contactId);
    }
}
