using System;
using Domain.Services;

namespace Services
{
  public class Calculo : ICalculoSevice
  {
    public decimal Calcular(decimal valorInicial, int meses)
    {
      var juros = 0.01;
      return Math.Round(valorInicial * Convert.ToDecimal(Math.Pow((1 + juros), meses)), 2);
    }
  }
}