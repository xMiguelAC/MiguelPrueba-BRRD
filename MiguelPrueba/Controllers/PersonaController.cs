using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiguelPrueba.Models;
using MiguelPrueba.DataAccess;

namespace MiguelPrueba.Controllers
{
    public class PersonaController: Controller
    {
        private readonly PersonaDataAccess _personaData;
        public PersonaController(PersonaDataAccess personaData)
        {
            _personaData = personaData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_personaData.ObtenerPersonas());
            //return View();
        }

        [HttpGet]
        public IActionResult AgregarPersona()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarPersona(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _personaData.AgregarPersona(persona);
                return RedirectToAction("Index");
            }

            return View(persona);
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            _personaData.EliminarPersona(id);
            return RedirectToAction("Index");
        }

    }
}
