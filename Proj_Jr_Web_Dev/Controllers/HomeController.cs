using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proj_Jr_Web_Dev.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_Jr_Web_Dev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region Home
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region ListarVagas
        [HttpGet]
        public JsonResult ListarVagas()
        {
            int qtdVagas = 8;
            List<VagasViewModel> vagas = new List<VagasViewModel>();

            for (var i = 0; i < qtdVagas; i++)
            {
                vagas.Add(new VagasViewModel() { Titulo = "Vendedor(a)", Cidade = "Sorocaba", Salario = 1700 });
            }

            return Json(vagas);
        }
        #endregion

        #region Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
