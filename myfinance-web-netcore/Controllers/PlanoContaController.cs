using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Infrastructure;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;

namespace myfinance_web_netcore.Controllers
{
    [Route("[controller]")]
    public class PlanoContaController : Controller
    {
        private readonly IPlanoContaServices _planoContaServices;

        public PlanoContaController(IPlanoContaServices planoContaServices)
        {
            _planoContaServices = planoContaServices;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Lista = _planoContaServices.ListarRegistros();
            return View();
        }

        [HttpGet]
        [HttpPost]
        [Route("Cadastro")]
        public IActionResult Cadastro(PlanoContaModel? model)
        {
            if (model != null && ModelState.IsValid)
            {
                var planoConta = new PlanoConta
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Tipo = model.Tipo
                };
                _planoContaServices.Salvar(planoConta);
            }

            return View();
        }
    }
}


