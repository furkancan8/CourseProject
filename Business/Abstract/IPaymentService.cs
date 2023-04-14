using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IResult Add(Payment payment);
        IResult Update(Payment payment);
        IResult Delete(int paymentId);
        IDataResult<List<Payment>> GetAll();
        IDataResult<Payment> GetById(int paymentId);
        IDataResult<List<Payment>> GetByUserId(int userId);
    }
}
