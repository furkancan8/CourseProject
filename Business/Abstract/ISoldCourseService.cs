using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoldCourseService
    {
        IResult Add(SoldCourse soldCourse);
        IResult Update(SoldCourse soldCourse);
        IResult Delete(int soldCourseId);
        IDataResult<List<SoldCourse>> GetAll();
        IDataResult<List<SoldCourse>> GetAllCourseId(int courseId);
        IDataResult<List<SoldCourse>> GetAllUserId(int userId);
        IDataResult<SoldCourse> GetById(int soldCourseId);
    }
}
