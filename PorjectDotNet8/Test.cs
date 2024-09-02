using Microsoft.AspNetCore.Mvc;

namespace PorjectDotNet8
{
	public class Test
	{
		[FromQuery]
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
