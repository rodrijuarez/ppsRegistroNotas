using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
    public class MateriaManager
    {
        private DatosMateria materiaDAO;

        public MateriaManager()
        {
            materiaDAO = new DatosMateria();
        }
        public List<Materia> TraerMateriasPorIdCarrera(int idCarrera)
        {
            return materiaDAO.TraerMateriasPorIdCarrera(idCarrera);
        }
    }
}
