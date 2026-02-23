namespace bendita_ajuda_back_end.Models
{
	public class Servico
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public bool? Aprovado { get; set; }
		public ICollection<Prestador>? Prestadores { get; set; }
	}
}
