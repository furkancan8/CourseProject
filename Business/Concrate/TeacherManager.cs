using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;
        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public IResult Add(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int teacherId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Teacher>> GetAll()
        {
           return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll());
        }

        public IDataResult<Teacher> GetById(int teacherId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
