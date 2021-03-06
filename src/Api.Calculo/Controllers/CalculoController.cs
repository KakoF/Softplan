using System.Threading.Tasks;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Calculo.Controllers
{
  [ApiController]
  [Route("calculajuros")]
  public class CalculoController : ControllerBase
  {
    private readonly ICalculoSevice _service;
    public CalculoController(ICalculoSevice service)
    {
      _service = service;
    }
    [HttpGet()]
    public async Task<ActionResult> Get([FromQuery()] decimal valorInicial, int meses)
    {
      return Ok(await _service.Calcular(valorInicial, meses));
    }
  }
}