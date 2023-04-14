using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class SectionCourseManager : ISectionCourseService
    {
        ISectionCourseDal _sectionCourseDal;
        public SectionCourseManager(ISectionCourseDal sectionCourseDal)
        {
            _sectionCourseDal = sectionCourseDal;
        }

        public IResult Add(SectionCourse sectionCourse)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int sectionCourseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SectionCourse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<SectionCourse> GetById(int sectionCourseId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SectionCourse sectionCourse)
        {
            throw new NotImplementedException();
        }
    }
}
