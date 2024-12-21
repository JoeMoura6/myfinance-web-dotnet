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
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(PlanoContaModel? model, int? id)
        {
            if (id != null && !ModelState.IsValid) //Carregar registro em tela
            {

                var registro = _planoContaServices.RetornarRegistro((int)id);

                var PlanoContaModel = new PlanoContaModel()
                {
                    Id = registro.Id,
                    Nome = registro.Nome,
                    Tipo = registro.Tipo
                };

                return View(PlanoContaModel);
            }
            else{
            if (model != null && ModelState.IsValid)
            {
                var planoConta = new PlanoConta
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Tipo = model.Tipo
                };
                _planoContaServices.Salvar(planoConta);

                return RedirectToAction("Index");

            }
            else 
            {
                return View();
            }
            }               
        }

        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _planoContaServices.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}