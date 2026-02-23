using bendita_ajuda_back_end.Dtos.Servicos;
using System.Threading.Tasks;

namespace bendita_ajuda_back_end.Services.Interfaces
{
	public interface IServicoService
	{
		Task<List<ServicoDto>> ListarAsync();
	}
}
