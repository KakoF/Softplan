using System.Threading.Tasks;
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
    public async Task Return_Decimal_EqualsAsync()
    {
      var retorno = new decimal(105.10);
      _serviceMock = new Mock<ICalculoSevice>();
      _serviceMock.Setup(m => m.Calcular(100, 5)).Returns(Task.FromResult(retorno));
      _service = _serviceMock.Object;
      var result = await _service.Calcular(100, 5);
      Assert.Equal(result.ToString(), 105.10.ToString());
    }

    [Fact(DisplayName = "Executou endpoint para recuperar o juros com erro")]
    public async Task Return_Decimal_WrongAsync()
    {
      var retorno = new decimal(105.10);
      _serviceMock = new Mock<ICalculoSevice>();
      _serviceMock.Setup(m => m.Calcular(100, 5)).Returns(Task.FromResult(0.00M));
      _service = _serviceMock.Object;
      var result = await _service.Calcular(100, 5);
      Assert.NotEqual(result.ToString(), 0.01.ToString());
    }
  }
}