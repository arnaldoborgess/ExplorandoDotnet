using Newtonsoft.Json;

namespace TiposNulos.Models
{
    public class Vendas
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string? Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}