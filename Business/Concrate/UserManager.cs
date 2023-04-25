using Business.Abstract;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Business.Concrate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IDataResult<User> GetByMail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);
            if(result!=null)
            {
                return new SuccessDataResult<User>(result);
            }
            return new ErrorDataResult<User>("Mail bulunamadı");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(i => i.Id == userId));
        }

        public IDataResult<List<OperationClaim>> GetUserClaims(int userId)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetUserClaims(userId));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
        public void SendMailOfChangePassword(string email)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "pop3.live.com";
            smtpClient.EnableSsl = true;
            Random random = new Random();
            int restCode = random.Next(100000, 999999);
            smtpClient.Credentials = new NetworkCredential("yamyam5863@hotmail.com", "15072002furkan");
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("yamyam5863@hotmail.com", "Furkan Can");
            mailMessage.To.Add("furkan_can45@hotmail.com");
            mailMessage.Subject = "Şifre sıfırlama kodunuz";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "Şifre sıfırlama kodunuz=" + restCode.ToString();
            smtpClient.Send(mailMessage);
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
