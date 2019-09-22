using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Penny.Web.AspNet.Controllers
{
    public class EstabelecimentoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}