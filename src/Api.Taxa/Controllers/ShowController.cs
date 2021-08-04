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
      return Ok("http://asdasd");
    }
  }
}