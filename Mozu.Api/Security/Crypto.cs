using System;
using System.Security.Cryptography;
using System.Text;

namespace Mozu.Api.Security
{
    public class Crypto
    {
        public static string GetHash(string secretKey, string body)
        {
            var payload = string.Concat(secretKey, body);
            byte[] hashArray;
            using (var encryptor = new SHA256Managed())
            {
                var payloadByteArray = Encoding.UTF8.GetBytes(payload);
                hashArray = encryptor.ComputeHash(payloadByteArray);
            }
            var hash = Convert.ToBase64String(hashArray);
            return hash;
        }
    }
}
