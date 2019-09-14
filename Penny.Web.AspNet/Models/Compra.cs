using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Penny.Web.AspNet.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime DataCompra { get; set; }
        public List<Produto> Produtos { get; set; }
        public Unidade Unidade { get; set; }
        public Clliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
