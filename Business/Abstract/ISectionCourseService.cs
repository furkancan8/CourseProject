using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISectionCourseService
    {
        IResult Add(SectionCourse sectionCourse);
        IResult Update(SectionCourse sectionCourse);
        IResult Delete(int sectionCourseId);
        IDataResult<List<SectionCourse>> GetAll();
        IDataResult<SectionCourse> GetById(int sectionCourseId);
    }
}
