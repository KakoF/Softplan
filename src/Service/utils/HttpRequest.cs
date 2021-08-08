using System;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.utils;

namespace Service.utils
{
  public class HttpRequest : IHttpRequest
  {

    private readonly HttpClient _httpClient;
    private string _baseUrl;
    //public HttpRequest(IConfiguration configuration)
    public HttpRequest()
    {
      _httpClient = new HttpClient();
      _baseUrl = Environment.GetEnvironmentVariable("URL_TAXA");

    }

    public async Task<string> GetRequest(string url)
    {
      string endpointPath = _baseUrl + url;

      HttpResponseMessage response = _httpClient.GetAsync(endpointPath).Result;
      if (!response.IsSuccessStatusCode)
        throw new Exception("Erro ao realizar a solicitação");
      return await response.Content.ReadAsStringAsync();
    }
  }
}