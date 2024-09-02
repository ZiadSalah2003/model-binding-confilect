using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PorjectDotNet8.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[HttpGet("")]
		public IActionResult Get(Test test)
		{
			return Ok(test);
		}
	}
}
