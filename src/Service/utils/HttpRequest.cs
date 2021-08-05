using System;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.utils;
using Microsoft.Extensions.Configuration;

namespace Service.utils
{
  public class HttpRequest : IHttpRequest
  {

    private readonly HttpClient _httpClient;
    private string _baseUrl;
    //public HttpRequest(IConfiguration configuration)
    public HttpRequest(IConfiguration configuration)
    {
      _httpClient = new HttpClient();
      _baseUrl = configuration["http_url_client"];

    }

    public async Task<string> GetRequest(string url)
    {
      string endpointPath = _baseUrl + url;

      // Make the request
      HttpResponseMessage response = _httpClient.GetAsync(endpointPath).Result;
      if (!response.IsSuccessStatusCode)
        throw new Exception("Erro ao realizar a solicitação");
      return await response.Content.ReadAsStringAsync();
    }
  }
}