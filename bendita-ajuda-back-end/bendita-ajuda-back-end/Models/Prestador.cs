namespace bendita_ajuda_back_end.Models
{
	public class Prestador
	{
		public string? Id { get; set; }
		public string? Nome { get; set; }
		public string? Email { get; set; }
		public string? Cep { get; set; }
		public string? Telefone { get; set; }
		public ICollection<Servico>? Servicos { get; set; }
	}
}
