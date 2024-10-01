using Microservicios.Web.Models;

namespace Microservicios.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true );
    }
}
