using Core.Entities.Concrate;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> VerifyPassword(UserForLoginDto userForLoginDto);
        IDataResult<User> ChangePassword(string password, int id);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IDataResult<DecodeAccessToken> DecodeAccessToken(User user);
        void SendMailOfChangePassword(string email, string randomCode);
    }
}
