using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Models;
using PONTODIGITAL.Repositorio;
using PONTODIGITAL.Repositorios;

namespace PONTODIGITAL.Controllers {
    public class FaqController : Controller {

        private FaqRepositorio FaqRepositorio = new FaqRepositorio ();

        [HttpGet]
        public IActionResult FaqDeslogado(){
            return View();
        }

        [HttpGet]
        public IActionResult Faq () {
            return View ();
        }

        public IActionResult Comentar(IFormCollection form) {
            Faq comentario = new Faq();
            comentario.Comentario = form["comentario"];

            FaqRepositorio.Inserir(comentario);

            return View("Faq");
        }
        [HttpGet]
        public IActionResult ListarComentarios(){
            FaqRepositorio comentario = new FaqRepositorio();
            ViewData["faq"] = comentario.ListarComentarios();

            return RedirectToAction("Admin","Admin");
        }

        public IActionResult Aprovar(){
            return RedirectToAction("Admin", "Admin");
        }
        
        
        
        
        
        //     Faq coment = new Faq ();
        //     coment.Comentario = form["coment"];

        //     FaqRepositorio.Inserir(coment);
        //     return View ("FAQ");
        // }
    }
}