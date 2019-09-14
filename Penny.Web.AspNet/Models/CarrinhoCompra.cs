﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Penny.Web.AspNet.Models
{
    public class CarrinhoCompra
    {
        public int CarrinhoCompraId { get; set; }
        public List<Produto> Produtos { get; set; }
        public DateTime DataCarrinho { get; set; }
        public bool Ativo { get; set; }

    }
}
