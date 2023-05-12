using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int commentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> GetAllCourse(int courseId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(i => i.CourseId == courseId));
        }

        public IDataResult<List<Comment>> GetAllUserComment(int userId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(i => i.UserId == userId));
        }

        public IDataResult<Comment> GetById(int commentId)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(i => i.Id == commentId));
        }

        public IResult Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
