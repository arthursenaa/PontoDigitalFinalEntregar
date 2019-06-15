using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Models;
using PONTODIGITAL.Repositorio;
using PONTODIGITAL.ViewModel;

namespace PONTODIGITAL.Controllers
{
    public class HomeController : Controller
    {

        private ClienteRepositorio clienteR = new ClienteRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);

            return View();
        }

        
        [HttpGet]
        public IActionResult IndexLogado(){
            return View();
        }


        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {   
            var email = form["email"];
            var senha = form ["senha"];
            var cliente = clienteR.ObterPor(email);
            
            if (cliente != null)
            {
                
                if(cliente.Tipo.Equals("Admin"))
                {      
                    return RedirectToAction("Adm", "Admin");

                }
                if(cliente.Senha.Equals(senha)){
                    HttpContext.Session.SetString(SESSION_EMAIL, email);
                    HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
                    return RedirectToAction("Index", "Home");
                }
                
                return RedirectToAction("Index", "Home");
            }else{
                return RedirectToAction("Index", "Home");
            }           
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult Listar(){
            ClienteRepositorio usuarioRepositorio = new ClienteRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.ListarTodos();

            return RedirectToAction("Admin","Admin");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}