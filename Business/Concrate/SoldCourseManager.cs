using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class SoldCourseManager : ISoldCourseService
    {
        ISoldCourseDal _soldCourseDal;
        public SoldCourseManager(ISoldCourseDal soldCourseDal)
        {
            _soldCourseDal = soldCourseDal;
        }

        public IResult Add(SoldCourse soldCourse)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int soldCourseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SoldCourse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SoldCourse>> GetAllCourseId(int courseId)
        {
            return new SuccessDataResult<List<SoldCourse>>(_soldCourseDal.GetAll(i => i.CourseId == courseId));
        }

        public IDataResult<List<SoldCourse>> GetAllUserId(int userId)
        {
            return new SuccessDataResult<List<SoldCourse>>(_soldCourseDal.GetAll(i => i.UserId == userId));
        }

        public IDataResult<SoldCourse> GetById(int soldCourseId)
        {
            return new SuccessDataResult<SoldCourse>(_soldCourseDal.Get(i => i.Id == soldCourseId));
        }

        public IResult Update(SoldCourse soldCourse)
        {
            throw new NotImplementedException();
        }
    }
}
