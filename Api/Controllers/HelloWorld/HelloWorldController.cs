using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.HelloWorld;

[ApiController]
[Route("hello-world")]
public class HelloWorldController : ControllerBase
{
	[HttpGet]
	public ActionResult<HelloWorld> Get()
	{
		return new HelloWorld();
	}
}