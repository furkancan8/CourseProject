using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class VideoDetailsManager : IVideoDetailsService
    {
        IVideoDetailsService _videoDetailsService;
        public VideoDetailsManager(IVideoDetailsService videoDetailsService)
        {
            _videoDetailsService = videoDetailsService;
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
            throw new NotImplementedException();
        }

        public IResult Update(VideoDetail videoDetail)
        {
            throw new NotImplementedException();
        }
    }
}
