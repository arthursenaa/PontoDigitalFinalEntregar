using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Repositorio;
using PONTODIGITAL.Repositorios;

namespace PONTODIGITAL.Controllers
{
    public class AdminController : Controller
    {   
        // [HttpGet]
        // public IActionResult Adm(){
        //     return View();
        // }

        [HttpGet]
        public IActionResult Adm(){
            ClienteRepositorio usuarioRepositorio = new ClienteRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.ListarTodos();

            return View();
        }
    }
}