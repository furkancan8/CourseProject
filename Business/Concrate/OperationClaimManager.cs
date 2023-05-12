using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _operationClaimDal;
        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public IResult Add(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int operationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll());
        }

        public IDataResult<OperationClaim> GetById(int operationClaimId)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(i => i.Id == operationClaimId)); ;
        }

        public IResult Update(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }
    }
}
