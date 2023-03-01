using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica01032023.UI.AppWebMVC.Models;
namespace Practica01032023.UI.AppWebMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        UserBL userBL = new UserBL();
        public ActionResult Index()
        {
            ViewBag.Titulo = "Buscar Usuarios";        
            var list = userBL.ObtenerTodos();
            return View(list);
        }

        
        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                int result = userBL.Crear(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
