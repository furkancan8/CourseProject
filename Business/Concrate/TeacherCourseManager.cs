using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class TeacherCourseManager : ITeacherCourseService
    {
        ITeacherCourseDal _teacherCourseDal;
        public TeacherCourseManager(ITeacherCourseDal teacherCourseDal)
        {
            _teacherCourseDal = teacherCourseDal;
        }

        public IResult Add(TeacherCourse teacherCourse)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int teacherCourseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TeacherCourse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<TeacherCourse> GetById(int teacherCourseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TeacherCourse>> GetTeacherId(int teacherId)
        {
            return new SuccessDataResult<List<TeacherCourse>>(_teacherCourseDal.GetAll(t => t.TeacherId == teacherId));
        }

        public IResult Update(TeacherCourse teacherCourse)
        {
            throw new NotImplementedException();
        }
    }
}
