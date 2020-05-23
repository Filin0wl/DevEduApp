using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp
{
    public interface ITokenManager
    {
        void SetToken(string token);
        string GetToken();
    }
}
