using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CourseDetailsManager : ICourseDetailsService
    {
        ICourseDetailsDal _courseDetailsDal;
        public CourseDetailsManager(ICourseDetailsDal courseDetailsDal)
        {
            _courseDetailsDal = courseDetailsDal;
        }
        public IResult Add(CourseDetails courseDetails)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int courseDetailsId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CourseDetails>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CourseDetails> GetById(int courseDetailsId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CourseDetails courseDetails)
        {
            throw new NotImplementedException();
        }
    }
}
