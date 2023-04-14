using Core.DataAccess;
using Core.Entities;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPaymentDal:IEntityRepository<Payment>
    {
    }
}
