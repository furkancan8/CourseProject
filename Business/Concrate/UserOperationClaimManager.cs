using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UserOperationClaimManager: IUserOperationClaimService
    {
        IUserOperationClaimDal _claimDal;
        public UserOperationClaimManager(IUserOperationClaimDal claimDal)
        {
            _claimDal = claimDal;
        }

        public IResult Add(UserOperationClaim claim)
        {
            _claimDal.Add(claim);
            return new SuccessResult();
        }

        public IResult Delete(int claimId)
        {
            _claimDal.Delete(claimId);
            return new SuccessResult();
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_claimDal.GetAll());
        }

        public IDataResult<UserOperationClaim> GetById(int claimId)
        {
            return new SuccessDataResult<UserOperationClaim>(_claimDal.Get(i => i.Id == claimId));
        }

        public IDataResult<List<OperationClaim>> GetOperationClaim()
        {
            return new SuccessDataResult<List<OperationClaim>>(_claimDal.GetOperationClaim());
        }

        public IResult Update(UserOperationClaim claim)
        {
            _claimDal.Update(claim);
            return new SuccessResult();
        }
    }
}
