using Core.Utilities.Results;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeacherStudentContactService
    {
        IResult Add(TeacherStudentContact teacherStudentContact);
        IResult Update(TeacherStudentContact teacherStudentContact);
        IResult Delete(int teacherStudentContacttId);
        IDataResult<List<TeacherStudentContact>> GetAll();
        IDataResult<TeacherStudentContact> GetById(int teacherStudentContactId);
    }
}
