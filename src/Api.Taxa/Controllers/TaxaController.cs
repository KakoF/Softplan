using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Taxa.Controllers
{
  [ApiController]
  [Route("taxaJuros")]
  public class TaxaController : ControllerBase
  {
    private readonly ITaxaService _service;
    public TaxaController(ITaxaService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult Get()
    {
      return Ok(_service.GetTaxa());
    }
  }
}