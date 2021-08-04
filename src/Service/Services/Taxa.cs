using Domain.Services;

namespace Services
{
  public class Taxa : ITaxaService
  {
    public decimal GetTaxa()
    {
      return 0.01M;
    }
  }
}