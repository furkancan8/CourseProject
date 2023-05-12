using Core.Utilities.Results;
using Entities.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IResult Add(Comment comment);
        IResult Update(Comment comment);
        IResult Delete(int commentId);
        IDataResult<List<Comment>> GetAll();
        IDataResult<List<Comment>> GetAllUserComment(int Id);
        IDataResult<List<Comment>> GetAllCourse(int courseId);
        IDataResult<Comment> GetById(int commentId);
    }
}
