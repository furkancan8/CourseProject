using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class SupportContactManager : ISupportContactService
    {
        ISupportContactDal _supportContactDal;
        public SupportContactManager(ISupportContactDal supportContactDal)
        {
            _supportContactDal = supportContactDal;
        }

        public IResult Add(SupportContact supportContact)
        {
           if(supportContact.HaveId==null)
            {
                supportContact.HaveId = "A1";

            }
            else
            {
                supportContact.IsRead=true;
            }
            _supportContactDal.Add(supportContact);
            return new SuccessResult();
        }

        public IResult Delete(int supportContactId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SupportContact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SupportContact>> GetAllByTeacherId(int teacherId)
        {
            return new SuccessDataResult<List<SupportContact>>(_supportContactDal.GetAll(i=>i.TeacherId==teacherId));
        }

        public IDataResult<SupportContact> GetById(int supportContactId)
        {
            return new SuccessDataResult<SupportContact>(_supportContactDal.Get(i => i.Id == supportContactId));
        }

        public IResult Update(SupportContact supportContact)
        {
            _supportContactDal.Update(supportContact);
            return new SuccessResult();
        }
    }
}
