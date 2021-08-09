using Domain.Services;

namespace Services
{
  public class Taxa : ITaxaService
  {
    public double GetTaxa()
    {
      return 0.01;
    }
  }
}