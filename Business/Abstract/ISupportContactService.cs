using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupportContactService
    {
        IResult Add(SupportContact supportContact);
        IResult Update(SupportContact supportContact);
        IResult Delete(int supportContactId);
        IDataResult<List<SupportContact>> GetAll();
        IDataResult<SupportContact> GetById(int supportContactId);
        IDataResult<List<SupportContact>> GetAllByTeacherId(int supportContactId);
    }
}
