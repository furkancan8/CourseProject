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
        IDataResult<Course> GetById(int courseId);
        IDataResult<Course> GetCourseById(int courseId);
    }
}
