using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class SectionCourseVideoManager : ISectionCourseVideoService
    {
        ISectionCourseVideoDal _sectionCourseVideoDal;
        public SectionCourseVideoManager(ISectionCourseVideoDal sectionCourseVideoDal)
        {
            _sectionCourseVideoDal = sectionCourseVideoDal;
        }

        public IResult Add(SectionCourseVideo sectionCourseV)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SectionCourseVideo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<SectionCourseVideo> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SectionCourseVideo sectionCourseV)
        {
            throw new NotImplementedException();
        }
    }
}
