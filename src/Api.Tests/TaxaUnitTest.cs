using Domain.Services;
using Moq;
using Xunit;

namespace Api.Tests
{
  public class TaxaUnitTest
  {
    private ITaxaService _service;
    private Mock<ITaxaService> _serviceMock;
    [Fact(DisplayName = "Executou endpoint para recuperar a taxa com sucesso")]
    public void Return_Decimal_Equals()
    {
      var retorno = new decimal(0.01);
      _serviceMock = new Mock<ITaxaService>();
      _serviceMock.Setup(m => m.GetTaxa()).Returns(retorno);
      _service = _serviceMock.Object;
      var result = _service.GetTaxa();
      Assert.Equal(result.ToString(), 0.01.ToString());
    }

    [Fact(DisplayName = "Executou endpoint para recuperar a taxa com erro")]
    public void Return_Decimal_Wrong()
    {
      var retorno = new decimal(0.02);
      _serviceMock = new Mock<ITaxaService>();
      _serviceMock.Setup(m => m.GetTaxa()).Returns(retorno);
      _service = _serviceMock.Object;
      var result = _service.GetTaxa();
      Assert.NotEqual(result.ToString(), 0.01.ToString());
    }
  }
}