using Core.DataAccess.EntityFramework;
using Core.Entities.Concrate;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfOperationClaimDal:EfEntityRepositoryBase<OperationClaim,CourseContext>,IOperationClaimDal
    {
    }
}
