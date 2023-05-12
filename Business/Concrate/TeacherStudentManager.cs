using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrate
{
    public class TeacherStudentManager : ITeacherStudentService
    {
        ITeacherStudentDal _teacherStudentDal;
        public TeacherStudentManager(ITeacherStudentDal teacherStudentDal)
        {
            _teacherStudentDal = teacherStudentDal;
        }

        public IResult Add(TeacherStudent teacherStudent)
        {
            _teacherStudentDal.Add(teacherStudent);
            return new SuccessResult();
        }

        public IResult Delete(int teacherStudentId)
        {
            _teacherStudentDal.Delete(teacherStudentId);
            return new SuccessResult();
        }

        public IDataResult<List<TeacherStudent>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TeacherStudent>> GetAllTeacherOfStudent(int teacherId)
        {
            return new SuccessDataResult<List<TeacherStudent>>(_teacherStudentDal.GetAll(i => i.TeacherId == teacherId)); ;
        }

        public IDataResult<TeacherStudent> GetById(int teacherStudentId)
        {
            return new SuccessDataResult<TeacherStudent>(_teacherStudentDal.Get(i => i.Id == teacherStudentId));
        }

        public IResult Update(TeacherStudent teacherStudent)
        {
            throw new NotImplementedException();
        }
    }
}
