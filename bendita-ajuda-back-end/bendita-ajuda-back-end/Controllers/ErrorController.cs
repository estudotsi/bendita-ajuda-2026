using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bendita_ajuda_back_end.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ErrorController : ControllerBase
	{
		public static class Codes
		{
			public const string ServiceServicoMrtodoListarAsync = "SRV-001";
		}
	}
}
