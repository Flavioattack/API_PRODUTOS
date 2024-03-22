using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("PRODUTO")]
    public class Produto : Notification
    {
        //Código do produto (sequencial e não nulo)
        [Column("COD_PRODUTO")]
        public int Codigo { get; set; }

        //Nome do produto (não nulo)
        [Column("NOME")]
        public string Nome { get; set; }

        //Descrição do Produto (não nulo)
        [Column("DESC_PRODUTO")]
        public int descricaoProduto { get; set; }

        //Valor do produto (não nulo)
        [Column("VALOR")]
        public decimal Valor { get; set; }

        //Quantidade em estoque do produto (não nulo)
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        //Data de fabricação do produto (não nulo)
        [Column("DATA_FABRICACAO")]
        public DateTime DataFabricacao { get; set; }

        //Data de validade do produto (não nulo)
        [Column("DATA_VALIDADE")]
        public DateTime DataValidade { get; set; }
        
        //Data de validade do produto (não nulo)
        [Column("DH_INCLUSAO")]
        public DateTime dataInclusao { get; set; }

        //Se o produto está ativo no sistema (não nulo)
        [Column("SITUACAO")]
        public string Situacao { get; set; }

        //Codigo do fornecedor (não nulo)
        [Column("COD_FORNECEDOR")]
        public int CodigoFornecedor { get; set; }

        //Descrição do fornecedor (não nulo)
        [Column("DESC_FORNECEDOR")]
        public int descricaoFornecedor { get; set; }

        //CNPJ DO FORNECEDOR (não nulo)
        [Column("CNPJ_FORNECEDOR")]
        public string CnpjFornecedor { get; set; }

    }
}
