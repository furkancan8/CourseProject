using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(int courseId);
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllCategoryByCourse(int categoryId);
        IDataResult<Course> GetById(int courseId);
        IDataResult<List<Course>> GetAllTeacherOfCourse(int teacherId);
        IDataResult<Course> GetCourseById(int courseId);

    }
}
