using System.Threading.Tasks;

namespace Domain.Services
{
  public interface ICalculoSevice
  {
    Task<decimal> CalcularAsync(decimal valorInicial, int meses);
  }
}