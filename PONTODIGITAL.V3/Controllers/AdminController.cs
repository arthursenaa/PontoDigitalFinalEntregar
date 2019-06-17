using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Repositorio;
using PONTODIGITAL.Repositorios;

namespace PONTODIGITAL.Controllers
{
    public class AdminController : Controller
    {   
        private const string SESSION_ADM = "_ADM";

        // [HttpGet]
        // public IActionResult Adm(){
        //     return View();
        // }

        [HttpGet]
        public IActionResult Adm(){
            ClienteRepositorio usuarioRepositorio = new ClienteRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.ListarTodos();
            ViewBag.Adm = HttpContext.Session.GetString(SESSION_ADM);
            return View();
        }
        [HttpGet]
        public IActionResult ListarComentarios(){
            FaqRepositorio comentario = new FaqRepositorio();
            ViewData["comentario"] = comentario.ListarComentarios();

            return RedirectToAction("Admin","Admin");
        }

    }
}