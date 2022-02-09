using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace Kore.Controllers
{
    public class HolaMundoController : Controller
    {
        public IActionResult Index()
        {
            return View("Bienvenido");
        }
        public string Welcome()
        {
            return "Salida del metodo Welcome";
        }

        public string Catalog()
        {
            return "Salida del Catalog";
        }

        public string Producto(string producto, int cantidad)
        {
            return HtmlEncoder.Default.Encode($"Pediste {cantidad} de {producto}");
        }
    }
}
