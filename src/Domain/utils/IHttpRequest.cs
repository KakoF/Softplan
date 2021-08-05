using System.Threading.Tasks;

namespace Domain.utils
{
  public interface IHttpRequest
  {
    Task<string> GetRequest(string url);
  }
}