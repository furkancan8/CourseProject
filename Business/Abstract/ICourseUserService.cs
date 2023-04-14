using Core.Entities.Concrate;
using Core.Utilities.Results;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseUserService
    {
        IResult Add(CourseUser courseUser);
        IResult Update(CourseUser courseUser);
        IResult Delete(int id);
        IDataResult<List<CourseUser>> GetAll();
        IDataResult<List<CourseUser>> GetByUserId(int userId);
        IDataResult<CourseUser> GetById(int courseUserId);
    }
}
