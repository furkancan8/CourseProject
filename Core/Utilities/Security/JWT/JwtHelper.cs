using Core.Entities.Concrate;
using Core.Extensions;
using Core.Utilities.Results;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Emit;
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
        public DecodeAccessToken DecodeToken()
        {
            AccessToken accessToken = new AccessToken();
            string token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjYwMDQiLCJlbWFpbCI6ImZ1cmthbl9jYW40NTVAaG90bWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjpbIkFkbWluIiwiVGVhY2hlciJdLCJuYmYiOjE2ODI5MzEyMjQsImV4cCI6MTY4MjkzMTgyNCwiaXNzIjoiZnVya2FuQGZ1cmthbi5jb20iLCJhdWQiOiJmdXJrYW5AZnVya2FuLmNvbSJ9.6OadzRsK7M5aWy9rDQ0LUKhRTJQ4_31pDldG4NIf6ilqiIFOshoHiNn9EK-Z7KosowQsPu3Mq4tXXyuzT6sT3g";
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);//securitykey oluşturmaya saglar
            var tokenHandler = new JwtSecurityTokenHandler();
            var claimsPrincipal = tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = securityKey,
                ValidateIssuer = true,
                ValidIssuer = _tokenOptions.Issuer,
                ValidateAudience = true,
                ValidAudience = _tokenOptions.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            
            var jwtToken = validatedToken as JwtSecurityToken;
            if (jwtToken != null)
            {

                var userId = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var email = claimsPrincipal.FindFirst(ClaimTypes.Email)?.Value;
                var name = claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value;
                var roles = claimsPrincipal.FindAll(ClaimTypes.Role).Select(x => x.Value).ToList();
                var result = claimsPrincipal.ClaimRoles();
                var expiration = jwtToken.ValidTo;
                return new DecodeAccessToken
                {
                    UserId = userId,
                    Email = email,
                    //Calims = roles,
                };
            }
            return null;
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
