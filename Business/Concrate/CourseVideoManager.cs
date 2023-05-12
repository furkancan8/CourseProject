using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CourseVideoManager : ICourseVideoService
    {
        ICourseVideoDal _courseVideoDal;
        public CourseVideoManager(ICourseVideoDal courseVideoDal)
        {
            _courseVideoDal = courseVideoDal;
        }
        public IResult Add(CourseVideo courseVideo)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int courseVideoId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CourseVideo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CourseVideo>> GetAllVideoByCourse(int courseId)
        {
            return new SuccessDataResult<List<CourseVideo>>(_courseVideoDal.GetAll(i => i.CourseId == courseId));
        }

        public IDataResult<CourseVideo> GetById(int courseVideoId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CourseVideo courseVideo)
        {
            throw new NotImplementedException();
        }
    }
}
