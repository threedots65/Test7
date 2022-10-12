using System;

namespace Data
{
    public class TokenData
    {
        public string AccessToken { get; set; }

        public DateTime ExpiresAt { get; set; }

        public string RefreshToken { get; set; }
    }
}