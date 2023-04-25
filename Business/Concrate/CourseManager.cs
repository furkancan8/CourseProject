using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int courseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll());
        }

        public IDataResult<Course> GetById(int courseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Course> GetCourseById(int courseId)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(i=>i.CourseId== courseId));
        }

        public IResult Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
