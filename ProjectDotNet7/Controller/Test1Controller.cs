using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectDotNet7.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class Test1Controller : ControllerBase
	{
		[HttpGet("")]
		public IActionResult Get(Test1 test)
		{
			return Ok(test);
		}
	}
}
