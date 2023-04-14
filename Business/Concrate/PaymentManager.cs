using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult();
        }

        public IResult Delete(int paymentId)
        {
            _paymentDal.Delete(paymentId);
            return new SuccessResult();
        }

        public IDataResult<List<Payment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Payment> GetById(int paymentId)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(i => i.Id == paymentId));
        }

        public IDataResult<List<Payment>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(i => i.UserId == userId));
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult();
        }
    }
}
