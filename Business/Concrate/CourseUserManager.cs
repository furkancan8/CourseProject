using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CourseUserManager : ICourseUserService
    {
        ICourseUserDal _courseUserDal;
        public CourseUserManager(ICourseUserDal courseUserDal)
        {
            _courseUserDal = courseUserDal;
        }

        public IResult Add(CourseUser courseUser)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CourseUser>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CourseUser> GetById(int courseUserId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CourseUser>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<CourseUser>>(_courseUserDal.GetAll(i => i.UserId == userId));
        }

        public IResult Update(CourseUser courseUser)
        {
            throw new NotImplementedException();
        }
    }
}
