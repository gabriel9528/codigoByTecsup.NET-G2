using Microservicios.Web.Models;
using Microservicios.Web.Service.IService;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Text.Json;
using static Microservicios.Web.Utility.SD;

namespace Microservicios.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ITokenProvider _tokenProvider;

        public BaseService(IHttpClientFactory clientFactory, ITokenProvider tokenProvider)
        {
            _clientFactory = clientFactory;
            _tokenProvider = tokenProvider;
        }
        public async Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true)
        {
            try
            {
                HttpClient client = _clientFactory.CreateClient("Microservicios1");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");

                //Token
                if (withBearer)
                {
                    var token = _tokenProvider.GetToken();
                    message.Headers.Add("Authorization", $"Bearer {token}");
                }

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
                    Console.WriteLine("Request JSON Data: " + jsonData);
                    message.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                }

                Console.WriteLine($"Sending request to {message.RequestUri} with method {message.Method}");

                HttpResponseMessage apiResponse = await client.SendAsync(message);
                var newResponse = string.Empty;
                if (!apiResponse.IsSuccessStatusCode)
                {
                    var errorContent = await apiResponse.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {apiResponse.StatusCode}, Details: {errorContent}");
                    //return new ResponseDto { IsSuccess = false, Message = errorContent };
                    var deserializedResponse = JsonConvert.DeserializeObject<ResponseDto>(errorContent);

                    newResponse = deserializedResponse?.Message;
                }
                

                switch (apiResponse.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        return new() { IsSuccess = false, Message = $"Not Found, {newResponse}" };
                    case HttpStatusCode.Forbidden:
                        return new() { IsSuccess = false, Message = $"Access Denied, {newResponse}" };
                    case HttpStatusCode.Unauthorized:
                        return new() { IsSuccess = false, Message = $"Unauthorized, {newResponse}" };
                    case HttpStatusCode.InternalServerError:
                        return new() { IsSuccess = false, Message = $"Internal Server Error, {newResponse}" };
                    case HttpStatusCode.BadRequest:
                        return new() { IsSuccess = false, Message = $"Bad Request, {newResponse}" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var apiResponseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                        return apiResponseDto;
                }
            }
            catch(Exception ex)
            {
                var dto = new ResponseDto
                {
                    Message = ex.Message,
                    IsSuccess = false
                };
                return dto;
            }
        }
    }
}
