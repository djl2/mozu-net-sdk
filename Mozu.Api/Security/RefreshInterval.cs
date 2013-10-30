using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozu.Api.Security
{
    public class RefreshInterval
    {
        public long AccessTokenExpirationInterval { get; set; }
        public long RefreshTokenExpirationInterval { get; set; }
        public DateTime AccessTokenExpiration { get; internal set; }
        public DateTime RefreshTokenExpiration { get; internal set; }
    }
}
