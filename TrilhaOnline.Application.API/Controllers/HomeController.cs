using System.Web.Mvc;

namespace TrilhaOnline.Application.API.Controllers
{
    /// <summary>
    /// View de redirecionamento para a biblioteca de APIs do Swagger
    /// </summary>
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Método de redirecionamento para abertura da página do swagger
            return RedirectToAction("", "swagger");
        }
    }
}