using SearchClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SearchClassLibrary.DTOs.ServiceResponse;

namespace SearchClassLibrary.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDto userDto);
        Task<LoginResponse> LoginAccount(LoginDto loginDto);
    }
}
