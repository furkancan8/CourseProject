using Core.Entities.Concrate;
using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //token decrypt etmek ve içinden bilgilere ulaşmak
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }//api deki appseting.json dosyasını okur
        private TokenOptions _tokenOptions;//appseting.json daki tokeopstions temsil eder.
        private DateTime _accessTokenExpiration;//accesstoken ne zman geçersiz olucak
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();//appsetting'deki tokenoptions bölümünü al ona tokenoptions'u enjekte et

        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);//token zamanının ne zman biticeğini ayarlar
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);//securitykey oluşturmaya saglar
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);//kullanıcagı anahtarı ve algoritmayı söyler
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);//4 parametreye göre token oluşturur
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }
            private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
            {

                var claims = new List<Claim>();
                claims.AddNameIdentifier(user.Id.ToString());//kulanıcıın ıd
                claims.AddEmail(user.Email);
                claims.AddName($"{user.FullName}");//kullanıcın adı soyadı
                claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());//rollerini seçip ekler

                return claims;
            }
        
    }
}
