using Core.Entities.Concrate;
using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userClaim);
        IResult Update(UserOperationClaim userClaim);
        IResult Delete(int userClaimId);
        IDataResult<List<UserOperationClaim>> GetAll();
        IDataResult<UserOperationClaim> GetById(int userClaimId);
        IDataResult<List<UserOperationClaim>> GetAllTeacherByClaim();

    }
}
