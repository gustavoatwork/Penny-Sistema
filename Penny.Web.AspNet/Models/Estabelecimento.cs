﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Penny.Web.AspNet.Models
{
    public class Estabelecimento : Usuario
    {
        public int UnidadeId { get; set; }
        public Usuario Usuario { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
        public int Cpnj { get; set; }

    }
}
