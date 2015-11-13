using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
    public class CarreraManager
    {
        private DatosCarreras carrerasDAO;

        public CarreraManager()
        {
            carrerasDAO = new DatosCarreras();
        }

        public List<Carrera> TraerTodos()
        {
            return carrerasDAO.TraerTodas();
        }
    }
}
