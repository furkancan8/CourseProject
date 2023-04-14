using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISectionCourseVideoService
    {
        IResult Add(SectionCourseVideo sectionCourseV);
        IResult Update(SectionCourseVideo sectionCourseV);
        IResult Delete(int Id);
        IDataResult<List<SectionCourseVideo>> GetAll();
        IDataResult<SectionCourseVideo> GetById(int Id);
    }
}
