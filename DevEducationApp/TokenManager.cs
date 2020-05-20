using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp 
{
    class TokenManager : ITokenManager
    {
        private string _token;
        public string GetToken()
        {
            return _token;
        }

        public void SetToken(string token)
        {
            _token = token;
        }
    }
}
