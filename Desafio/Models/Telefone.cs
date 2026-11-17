namespace Desafio.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string DDD { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
    }
}