using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Penny.Web.AspNet.Models
{
    public class Acesso
    {
        public int AcessoId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Usuario usuario { get; set; }

    }
}
