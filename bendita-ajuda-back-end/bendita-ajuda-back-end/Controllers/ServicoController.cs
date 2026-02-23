using bendita_ajuda_back_end.Dtos.Servicos;
using bendita_ajuda_back_end.Models;
using bendita_ajuda_back_end.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace bendita_ajuda_back_end.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
		private readonly IServicoService _service;

		public ServicoController(IServicoService service)
		{
			_service = service;
		}

		[HttpGet]
		[ProducesResponseType(typeof(List<ServicoDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<List<ServicoDto>>> Listar()
		{
			try
			{
				var servicos = await _service.ListarAsync();
				return Ok(servicos);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Erro interno: {ex.Message}");
			}
		}

	}
}
