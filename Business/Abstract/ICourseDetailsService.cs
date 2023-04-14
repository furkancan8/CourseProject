using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseDetailsService
    {
        IResult Add(CourseDetails courseDetails);
        IResult Update(CourseDetails courseDetails);
        IResult Delete(int courseDetailsId);
        IDataResult<List<CourseDetails>> GetAll();
        IDataResult<CourseDetails> GetById(int courseDetailsId);
    }
}
