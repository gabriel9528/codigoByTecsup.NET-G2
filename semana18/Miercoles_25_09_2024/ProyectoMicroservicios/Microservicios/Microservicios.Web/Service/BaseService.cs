using Microservicios.Web.Models;
using Microservicios.Web.Service.IService;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using static Microservicios.Web.Utility.SD;

namespace Microservicios.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _clientFactory;

        public BaseService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<ResponseDto?> SendAsync(RequestDto requestDto)
        {
            try
            {
                HttpClient client = _clientFactory.CreateClient("Microservicios");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");

                //Token

                message.RequestUri = new Uri(requestDto.Url);

                message.Method = requestDto.ApiType switch
                {
                    ApiType.GET => HttpMethod.Get,
                    ApiType.POST => HttpMethod.Post,
                    ApiType.PUT => HttpMethod.Put,
                    ApiType.DELETE => HttpMethod.Delete,
                    _ => HttpMethod.Get,
                };

                if (requestDto.Data != null)
                {
                    var jsonData = JsonConvert.SerializeObject(requestDto.Data);
                    Console.WriteLine("Reques Json Data: " + jsonData);
                    message.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                }

                Console.WriteLine($"Sending request to {message.RequestUri} with method: {message.Method}");

                HttpResponseMessage apiResponse = await client.SendAsync(message);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    var errorContent = await apiResponse.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error:  {apiResponse.StatusCode}, Detailes: {errorContent}");
                }

                switch (apiResponse.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        return new() { IsSuccess = false, Message = "Error 404: No se encontro el recurso" };
                    case HttpStatusCode.Forbidden:
                        return new() { IsSuccess = false, Message = "Error 403: No tiene permisos para acceder al recurso" };
                    case HttpStatusCode.Unauthorized:
                        return new() { IsSuccess = false, Message = "Error 401: No esta autorizado para acceder al recurso" };
                    case HttpStatusCode.BadRequest:
                        return new() { IsSuccess = false, Message = "Error 400: Solicitud incorrecta" };
                    case HttpStatusCode.InternalServerError:
                        return new() { IsSuccess = false, Message = "Error 500: Error interno del servidor" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var responseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                        return responseDto;


                }
            }
            catch (Exception ex)
            {
                var dto = new ResponseDto
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };

                return dto;
            }
        }
    }
}
