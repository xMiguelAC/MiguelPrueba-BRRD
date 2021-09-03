using MiguelPrueba.Database;
using MiguelPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiguelPrueba.DataAccess
{
    public class PersonaDataAccess
    {
        private readonly Context _context;
        public PersonaDataAccess(Context context)
        {
            _context = context;
        }

        public List<Persona> ObtenerPersonas()
        {
            //try
            //{
                return _context.personas.ToList();
                
            //}
            //catch (Exception e)
            //{
              //  throw e.GetBaseException();
            //}
        }

        public void AgregarPersona(Persona persona)
        {
            try
            {
                _context.personas.Add(persona);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        public void EliminarPersona(int id)
        {
            try
            {
                Persona persona = _context.personas.Find(id);
                _context.personas.Remove(persona);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
    }
}
