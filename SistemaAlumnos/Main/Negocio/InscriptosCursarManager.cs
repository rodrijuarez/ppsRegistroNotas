using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
    public class InscriptosCursarManager
    {
        private DatosInscriptosCursar inscriptosCursarDAO;

        public InscriptosCursarManager()
        {
            inscriptosCursarDAO = new DatosInscriptosCursar();
        }

        public List<InscriptosCursar> TraerPorIdTurnoCursarYLegajo(int idTurnosCursar, int idLegajo)
        {
            return inscriptosCursarDAO.TraerPorIdTurnoCursarYLegajo(idTurnosCursar, idLegajo);
        }

        public List<InscriptosCursar> Actualizar(InscriptosCursar inscriptoCursar)
        {
            return inscriptosCursarDAO.Actualizar(inscriptoCursar);
        }

        public List<InscriptosCursar> TraerPorIdTurnoCursar(int idTurnosCursar)
        {
            return inscriptosCursarDAO.TraerPorIdTurnoCursar(idTurnosCursar);
        }

        public int TraerIdTurno(string Turno)
        {
            return inscriptosCursarDAO.TraerIdTurno(Turno);
        }
    }
}
