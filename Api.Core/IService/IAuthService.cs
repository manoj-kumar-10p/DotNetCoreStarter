using Api.Database.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api.Core.DTO;

namespace Api.Core.IService
{
    public interface IAuthService
    {
        Task DeleteAsync(long id);

        Task<DataTransferObject<LoginResponseDTO>> Login(LoginDTO credentials);

        Task<DataTransferObject<LoginResponseDTO>> RefreshToken(AuthStoreDTO tokenDto);

        Task<DataTransferObject<RevokeResponseDTO>> RevokeToken(AuthStoreDTO tokenDto);

        Task<DataTransferObject<bool>> Logout();
    }
}
