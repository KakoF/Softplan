using System;
using System.Threading.Tasks;
using Domain.Services;
using Domain.utils;

namespace Services
{
  public class Calculo : ICalculoSevice
  {
    private readonly IHttpRequest _request;
    public Calculo(IHttpRequest request)
    {
      _request = request;
    }
    public async Task<decimal> CalcularAsync(decimal valorInicial, int meses)
    {
      var juros = Double.Parse(await _request.GetRequest("taxaJuros")) / 100;
      return Math.Round(valorInicial * Convert.ToDecimal(Math.Pow((1 + juros), meses)), 2);
    }
  }
}