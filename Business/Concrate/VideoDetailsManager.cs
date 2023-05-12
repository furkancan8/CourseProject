using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class VideoDetailsManager : IVideoDetailsService
    {
        IVideoDetailsDal _videoDetailsDal;
        public VideoDetailsManager(IVideoDetailsDal videoDetailsDal)
        {
            _videoDetailsDal = videoDetailsDal;
        }

        public IResult Add(VideoDetail videoDetail)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int videoDetailId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<VideoDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<VideoDetail> GetById(int videoDetailId)
        {
            return new SuccessDataResult<VideoDetail>(_videoDetailsDal.Get(i=>i.Id== videoDetailId));
        }

        public IResult Update(VideoDetail videoDetail)
        {
            throw new NotImplementedException();
        }
    }
}
