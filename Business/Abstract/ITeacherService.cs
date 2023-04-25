using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IResult Add(Teacher teacher);
        IResult Update(Teacher teacher);
        IResult Delete(int teacherId);
        IDataResult<List<Teacher>> GetAll();
        IDataResult<Teacher> GetById(int teacherId);
    }
}
