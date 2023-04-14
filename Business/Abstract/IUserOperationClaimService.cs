using Core.Entities.Concrate;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<UserOperationClaim> GetById(int claimId);
        IDataResult<List<UserOperationClaim>> GetAll();
        IResult Add(UserOperationClaim cliam);
        IResult Update(UserOperationClaim claim);
        IResult Delete(int claimId);
        IDataResult<List<OperationClaim>> GetOperationClaim();
    }
}
