using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVideoDetailsService
    {
        IResult Add(VideoDetail videoDetail);
        IResult Update(VideoDetail videoDetail);
        IResult Delete(int videoDetailId);
        IDataResult<List<VideoDetail>> GetAll();
        IDataResult<VideoDetail> GetById(int videoDetailId);
    }
}
