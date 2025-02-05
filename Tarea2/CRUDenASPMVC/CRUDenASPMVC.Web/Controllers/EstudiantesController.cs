using CRUDenASPMVC.Web.Data;
using CRUDenASPMVC.Web.Models;
using CRUDenASPMVC.Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDenASPMVC.Web.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        
        public EstudiantesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ModeloVistaEstudiante viewModel)
        {
            var estudiante = new Estudiante
            {
                Nombre = viewModel.Nombre,
                Email = viewModel.Email,
                Telefono = viewModel.Telefono,
                Suscrito = viewModel.Suscrito
            };

            await dbContext.Estudiantes.AddAsync(estudiante);
            await dbContext.SaveChangesAsync();
            
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> List()
        {
            var estudiantes = await dbContext.Estudiantes.ToListAsync();

            return View(estudiantes);
        }

        [HttpGet]

        public async Task<IActionResult> Edit(Guid id)
        {
            var estudiante = await dbContext.Estudiantes.FindAsync(id);

            return View(estudiante);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Estudiante viewModel)
        {
            var estudiante = await dbContext.Estudiantes.FindAsync(viewModel.Id);

            if (estudiante is not null)
            {
                estudiante.Nombre = viewModel.Nombre;
                estudiante.Email = viewModel.Email;
                estudiante.Telefono = viewModel.Telefono;
                estudiante.Suscrito = viewModel.Suscrito;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Estudiantes");
        }

        [HttpPost]
        public async Task<IActionResult> Borrar(Estudiante viewModel)
        {
            var estudiante = await dbContext.Estudiantes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (estudiante is not null)
            {
                dbContext.Estudiantes.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Estudiantes");
        }
    }
}
