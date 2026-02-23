using bendita_ajuda_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace bendita_ajuda_back_end.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options) { }

		public DbSet<Prestador> Prestadores { get; set; }
		public DbSet<Servico> Servicos { get; set; }
	}
}
