using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class Actas
    {
        public int IdTomo { get; set; }

        public int IdFolio { get; set; }

        public DateTime Fecha { get; set; }

        public string IdCarrera { get; set; }

        public string IdMateria { get; set; }

        public int Inscriptos { get; set; }

        public string Estado { get; set; }

        public int Aprobados { get; set; }

        public int Ausentes { get; set; }

        public int Desaprobados { get; set; }

        public int IdUsuarioResponsable { get; set; }

        public DateTime FechaIngreso { get; set; }
    }
}
