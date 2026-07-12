using Microsoft.AspNetCore.Mvc;
using SistemaBibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBibliotecaMVC.Controllers
{
    public class LibrosController : Controller
    {
        private static List<LibroViewModel> _libros = new List<LibroViewModel>
        {
            new LibroViewModel { id = 1, Title = "Cien años de soledad", Author = "Gabriel García Márquez", Release = 1967, Category = "Novela" },
            new LibroViewModel { id = 2, Title = "Don Quijote de la Mancha", Author = "Miguel de Cervantes", Release = 1605, Category = "Clásico" },
            new LibroViewModel { id = 3, Title = "El Aleph", Author = "Jorge Luis Borges", Release = 1949, Category = "Cuentos" }
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Gestión de libros";
            ViewBag.Mensaje = "Listado de libros registrados";
            return View(_libros);
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            ViewData["Title"] = "Detalle del libro";
            var libro = _libros.FirstOrDefault(l => l.id == id);
            if (libro == null) return Redirect("/biblioteca/libros");
            return View(libro);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            ViewData["Title"] = "Registrar libro";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(LibroViewModel model)
        {
            ViewData["Title"] = "Registrar libro";
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.id = _libros.Any() ? _libros.Max(l => l.id) + 1 : 1;
            _libros.Add(model);

            TempData["Exito"] = "Libro registrado correctamente";
            return Redirect("/biblioteca/libros");
        }
    }
}