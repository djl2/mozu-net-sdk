using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mozu.Api.Security
{
    internal class MessageAuthentication
    {
        public static string Generate(string secretKey, string body)
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
