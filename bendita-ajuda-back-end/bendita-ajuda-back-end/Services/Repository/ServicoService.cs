using bendita_ajuda_back_end.Data;
using bendita_ajuda_back_end.Dtos.Servicos;
using bendita_ajuda_back_end.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bendita_ajuda_back_end.Services.Repository
{
	public class ServicoService : IServicoService
	{
		private readonly Context _context;

		public ServicoService(Context context)
		{
			_context = context;
		}
		public async Task<List<ServicoDto>> ListarAsync()
		{
			try
			{
				var servicos = await _context.Servicos.ToListAsync();

				var servicoDtos = servicos.Select(s => new ServicoDto
				{
					Id = s.Id,
					Nome = s.Nome,
					Aprovado = s.Aprovado
				}).ToList();

				return servicoDtos;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro: SRV-001");
			}
		}
	}
}
