using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Super10.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
    }
}
