namespace Domain.Services
{
  public interface ITaxaService
  {
    decimal GetTaxa(decimal valorInicial, int meses);
  }
}