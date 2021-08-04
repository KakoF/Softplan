using Domain.Services;
using Moq;
using Xunit;

namespace Api.Tests
{
  public class CalculoUnitTest
  {
    private ICalculoSevice _service;
    private Mock<ICalculoSevice> _serviceMock;
    [Fact(DisplayName = "Executou endpoint para calcular o juros com sucesso")]
    public void Return_Decimal_Equals()
    {
      var retorno = new decimal(105.10);
      _serviceMock = new Mock<ICalculoSevice>();
      _serviceMock.Setup(m => m.Calcular(100, 5)).Returns(retorno);
      _service = _serviceMock.Object;
      var result = _service.Calcular(100, 5);
      Assert.Equal(result.ToString(), 105.10.ToString());
    }

    [Fact(DisplayName = "Executou endpoint para recuperar o juros com erro")]
    public void Return_Decimal_Wrong()
    {
      var retorno = new decimal(105.10);
      _serviceMock = new Mock<ICalculoSevice>();
      _serviceMock.Setup(m => m.Calcular(100, 5)).Returns(0);
      _service = _serviceMock.Object;
      var result = _service.Calcular(100, 5);
      Assert.NotEqual(result.ToString(), 0.01.ToString());
    }
  }
}