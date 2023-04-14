using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseVideoService
    {
        IResult Add(CourseVideo courseVideo);
        IResult Update(CourseVideo courseVideo);
        IResult Delete(int courseVideoId);
        IDataResult<List<CourseVideo>> GetAll();
        IDataResult<CourseVideo> GetById(int courseVideoId);
    }
}
