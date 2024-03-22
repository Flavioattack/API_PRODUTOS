using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class ProdutoModel
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int descricaoProduto { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }                
        public int CodigoFornecedor { get; set; }
        public int descricaoFornecedor { get; set; }
        public string CnpjFornecedor { get; set; }
        public string Situacao { get; set; }
    }
}
