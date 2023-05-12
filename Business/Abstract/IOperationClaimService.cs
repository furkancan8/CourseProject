using Core.Entities.Concrate;
using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IResult Add(OperationClaim operationClaim);
        IResult Update(OperationClaim operationClaim);
        IResult Delete(int operationClaimId);
        IDataResult<List<OperationClaim>> GetAll();
        IDataResult<OperationClaim> GetById(int operationClaimId);
    }
}
