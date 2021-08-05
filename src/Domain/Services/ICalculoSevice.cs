using System.Threading.Tasks;

namespace Domain.Services
{
  public interface ICalculoSevice
  {
    Task<decimal> Calcular(decimal valorInicial, int meses);
  }
}