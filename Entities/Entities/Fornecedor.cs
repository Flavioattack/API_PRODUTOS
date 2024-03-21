using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("FORNECEDOR")]
    public class Fornecedor : Notification
    {
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
