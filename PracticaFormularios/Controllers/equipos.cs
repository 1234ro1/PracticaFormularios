using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaFormularios.Models;

namespace PracticaFormularios.Controllers
{
    public class equipos : Controller
    {
        private readonly equiContext _equiContext; 
        public  equipos(equiContext equiContext) 
        {
            _equiContext = equiContext;
        }
        public IActionResult Index()
        {
            var listadoDeMarcas = (from m in _equiContext.marcas select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listadoDeMarcas, "id_marcas", "nombre_marca");
            

            var listadoTipoEquipo = (from tp in _equiContext.tipo_equipo select tp).ToList();
            ViewData["listadoTipoEquipos"] = new SelectList(listadoTipoEquipo, "id_tipo_equipo", "descripcion");


            var listadoEstadosEquipo = (from eq in _equiContext.estados_equipo select eq).ToList();
            ViewData["listadoEstadosEquipo"] = new SelectList(listadoEstadosEquipo, "id_estados_equipo", "estado");
            return View();
        }
        public IActionResult crearRegistro(equipos nuevosEquipo)
        {
            _equiContext.Add(nuevosEquipo);
            _equiContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
