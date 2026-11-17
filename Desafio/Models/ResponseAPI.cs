namespace Desafio.Models
{
    public class ResponseAPI
    {
        public bool Success { get; set; }

        public int Id { get; set; }

        public string Error { get; set; } = string.Empty;

        public List<Pessoa> Pessoas { get; set; } = new();
    }
}