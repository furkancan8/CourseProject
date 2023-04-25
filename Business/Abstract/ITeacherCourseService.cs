using Core.Utilities.Results;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeacherCourseService
    {
        IResult Add(TeacherCourse teacherCourse);
        IResult Update(TeacherCourse teacherCourse);
        IResult Delete(int teacherCourseId);
        IDataResult<List<TeacherCourse>> GetAll();
        IDataResult<TeacherCourse> GetById(int teacherCourseId);
        IDataResult<List<TeacherCourse>> GetTeacherId(int teacherId);

    }
}
