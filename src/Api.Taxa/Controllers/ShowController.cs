using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Taxa.Controllers
{
  [ApiController]
  [Route("showmethecode")]
  public class ShowController : ControllerBase
  {
    [HttpGet]
    public ActionResult Get()
    {
      return Ok("https://github.com/KakoF/Softplan");
    }
  }
}