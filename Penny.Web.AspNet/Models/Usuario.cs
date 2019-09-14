using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Penny.Web.AspNet.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public TipoUsuario Tipo { get; set; }
        public Endeco Endeco { get; set; }
        public byte[] Foto { get; set; }

    }
}
