using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaimDal;
        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IResult Add(UserOperationClaim userClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int userClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll());
        }

        public IDataResult<List<UserOperationClaim>> GetAllTeacherByClaim()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll(i=>i.OperationClaimId==2));
        }

        public IDataResult<UserOperationClaim> GetById(int userClaimId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserOperationClaim userClaim)
        {
            throw new NotImplementedException();
        }
    }
}
