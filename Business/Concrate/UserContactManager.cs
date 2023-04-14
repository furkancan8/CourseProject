using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UserContactManager : IUserContactService
    {
        IUserContactDal _userContactDal;
        public UserContactManager(IUserContactDal userContactDal)
        {
            _userContactDal = userContactDal;
        }

        public IResult Add(UserContact contact)
        {
            _userContactDal.Add(contact);
            return new SuccessResult();
        }

        public IResult Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserContact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserContact> GetById(int contactId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserContact contact)
        {
            throw new NotImplementedException();
        }
    }
}
