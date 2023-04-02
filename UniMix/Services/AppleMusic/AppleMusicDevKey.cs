using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace UniMix.Services.AppleMusic
{
    public class AppleMusicDevKey
    {
        static string? _key;
        static bool KeyExpired => IsExpired(_key!);
        public static string Key
        {
            get
            {
                if (_key is not null && KeyExpired is false) return _key;
                _key = GetKey();
                return _key;
            }
        }
        //implement later a way to check if the jwt string is expired
        static bool IsExpired(string key)
        {
            return false;
        }
        static string GetKey()
        {
            var key = ECDsa.Create();
            key.ImportFromPem(File.ReadAllText($"C:\\Users\\Steve\\Downloads\\AuthKey_LHG24572T2.p8", Encoding.UTF8));
            SigningCredentials credentials = new(new ECDsaSecurityKey(key), SecurityAlgorithms.EcdsaSha256);

            JwtHeader header = new(credentials)
            {
                { "kid", "LHG24572T2" }
            };
            var now = DateTime.UtcNow;

            JwtPayload permClaims = new("XSJ7FF8L5Z", "", null, now, now.AddMonths(5));

            var secToken = new JwtSecurityToken(header, permClaims);
            var handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(secToken);
        }
    }
}
