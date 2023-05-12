using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class TeacherStudentContactManager : ITeacherStudentContactService
    {
        ITeacherStudentContactDal _teacherStudentDal;
        public TeacherStudentContactManager(ITeacherStudentContactDal teacherStudentDal)
        {
            _teacherStudentDal = teacherStudentDal;
        }

        public IResult Add(TeacherStudentContact teacherStudentContact)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int teacherStudentContacttId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TeacherStudentContact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<TeacherStudentContact> GetById(int teacherStudentContactId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TeacherStudentContact teacherStudentContact)
        {
            throw new NotImplementedException();
        }
    }
}
