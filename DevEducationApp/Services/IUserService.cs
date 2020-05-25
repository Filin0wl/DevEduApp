using DevEducationApp.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationApp.Services
{
    public interface IUserService
    {
        Task Auth(LoginDTO model);
    }
}
