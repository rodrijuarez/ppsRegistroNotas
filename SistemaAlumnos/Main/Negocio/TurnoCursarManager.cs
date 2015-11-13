using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
    public class TurnoCursarManager
    {
        public List<TurnoCursar> TraerTurnoCursarPorIdMateria(int idMateria)
        {
            return DatosTurnoCursar.TraerTurnoCursarPorIdMateria(idMateria);
            //return null;
        }

        public List<TurnoCursar> TraerTurnoCursarPorIdMateriaYTurno(int idMateria,string turno)
        {
            return DatosTurnoCursar.TraerTurnoCursarPorIdMateriaYTurno(idMateria, turno);
            //return null;
        }

        public TurnoCursar TraerTurnoCursarFiltrado(int idMateria, string turno, int division)
        {
            return DatosTurnoCursar.TraerTurnoCursarFiltrado(idMateria, turno, division);
            //return null;
        }
    }
}
