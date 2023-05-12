using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeacherStudentService
    {
        IResult Add(TeacherStudent teacherStudent);
        IResult Update(TeacherStudent teacherStudent);
        IResult Delete(int teacherStudentId);
        IDataResult<List<TeacherStudent>> GetAll();
        IDataResult<List<TeacherStudent>> GetAllTeacherOfStudent(int teacherId);
        IDataResult<TeacherStudent> GetById(int teacherStudentId);
    }
}
