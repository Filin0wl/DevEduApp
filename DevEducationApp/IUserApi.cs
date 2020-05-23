using DevEducationApp.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationApp
{
    [Headers("Content-Type: application/json")]
    interface IUserApi
    {
        [Post("/token")]
        Task<ReceiveTokenDTO> Login(LoginDTO model);

        /*[Get("/api/User/get-by-login")]
        Task<ReceiveUserDTO> GetUserByLogin(GetUserByLoginDTO model, [Header("Authorization")] string token);

        [Get("/api/User/{id}")]
        Task<ReceiveUserDTO> GetUserById(int id, [Header("Authorization")] string token);*/

    }
}
