using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrate;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class UserVerifyManager : IUserVerifyService
    {
        IUserVerifyDal _userVerifyDal;
        IUserDal _userDal;
        IAuthService _authService;
        public UserVerifyManager(IUserVerifyDal userVerifyDal,IUserDal userDal, IAuthService authService)
        {
            _userVerifyDal = userVerifyDal;
            _userDal = userDal;
            _authService = authService;
        }

        public async Task<IResult> Add(UserVerify userVerify)
        {
            Random random = new Random();
            var rdnCode = random.Next(100000, 999999);
            userVerify.RandomCode = rdnCode.ToString();
            var userResult = _userVerifyDal.Get(i => i.UserMail == userVerify.UserMail);
            var result = BusinessRules.Run(
                CheckIfSameNotMail(userVerify.UserMail));
            if(result!=null)
            {
                userResult.RandomCode = rdnCode.ToString();
                _userVerifyDal.Update(userResult);
                _authService.SendMailOfChangePassword(userVerify.UserMail, userVerify.RandomCode);
                return new SuccessResult();
            }

            _userVerifyDal.Add(userVerify);
            _authService.SendMailOfChangePassword(userVerify.UserMail, userVerify.RandomCode);
            await ScheduleDelete(userVerify.Id);
            return new SuccessResult();
        }
        public async Task<IResult> VerifyEmailUserAdd(UserVerify userVerify,int userId)
        {
            var user = _userDal.Get(i => i.Id == userId);
            Random random = new Random();
            var rdnCode = random.Next(100000, 999999);
            userVerify.RandomCode = rdnCode.ToString();
            var userResult = _userVerifyDal.Get(i => i.UserMail == user.Email);
            var result = BusinessRules.Run(
                       CheckIfSameNotMail(user.Email));
            if (result != null)
            {
                userResult.RandomCode = rdnCode.ToString();
                _userVerifyDal.Update(userResult);
                _authService.SendMailOfChangePassword(userResult.UserMail, userResult.RandomCode);
                return new SuccessResult();
            }
            _userVerifyDal.Add(userVerify);
            _authService.SendMailOfChangePassword(userVerify.UserMail, userVerify.RandomCode);
            await ScheduleDelete(userVerify.Id);
            return new SuccessResult();
        }
        private async Task ScheduleDelete(int userId)
        {

            await Task.Delay(TimeSpan.FromMinutes(3));
            _userVerifyDal.Delete(userId);
            return;
        }
        public IResult Delete(int userVerifyId)
        {
            _userVerifyDal.Delete(userVerifyId);
            return new SuccessResult();
        }

        public IDataResult<List<UserVerify>> GetAll()
        {
            return new SuccessDataResult<List<UserVerify>>(_userVerifyDal.GetAll());
        }

        public IDataResult<UserVerify> GetById(int userVerifyId)
        {
            return new SuccessDataResult<UserVerify>(_userVerifyDal.Get(i=>i.Id==userVerifyId));
        }

        public IDataResult<UserVerify> GetByMail(string userMail)
        {
            return new SuccessDataResult<UserVerify>(_userVerifyDal.Get(i => i.UserMail == userMail));
        }

        public IResult Update(UserVerify userVerify)
        {
            throw new NotImplementedException();
        }

        public IResult CheckIfSameNotMail(string mail)
        {
            var result = _userVerifyDal.GetAll(i => i.UserMail == mail).Any();
            if(result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        public IResult CheckIfSameUserMail(string mail)
        {
            var checkSameMail = _userDal.GetAll(i => i.Email == mail);
            if(checkSameMail.Count==0)
            {
                return new ErrorResult("Böyle bir email yok");
            }
            return new SuccessResult();
        }
    }
}
