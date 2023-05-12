using Business.Abstract;
using Core.Constans;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Business.Concrate
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FullName = userForRegisterDto.FullName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }
        public IDataResult<User> ChangePassword(string password, int id)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var result = _userService.GetById(id);
            result.Data.PasswordHash = passwordHash;
            result.Data.PasswordSalt = passwordSalt;
            _userService.Update(result.Data);
            return new SuccessDataResult<User>(result.Data, Messages.UserRegistered);
        }
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck.Data, "başarılı giriş");
        }
        public IDataResult<User> VerifyPassword(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck.Data, "Başarılı Giriş");
        }
        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {

            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
        public IDataResult<DecodeAccessToken> DecodeAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.DecodeToken();
            return new SuccessDataResult<DecodeAccessToken>(accessToken,"Token çözümleme başarılı");
        }
        public void SendMailOfChangePassword(string email,string randomCode)
        {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 587;
                smtpClient.Host = "pop3.live.com";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("yamyam5863@hotmail.com", "15072002furkan");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("yamyam5863@hotmail.com", "Furkan Can");
                mailMessage.To.Add(email);
                mailMessage.Subject = "Şifre sıfırlama kodunuz";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "Şifre sıfırlama kodunuz=" + randomCode.ToString();
                smtpClient.Send(mailMessage);
        }
    }
}
