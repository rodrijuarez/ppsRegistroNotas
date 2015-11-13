using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class InscriptosRendir
    {
        public int IdTurnosRendir { get; set; }

        public string IdLegajo { get; set; }

        public string Estado { get; set; }

        public string FechaElegida { get; set; }

        public int IdTomo { get; set; }

        public int IdFolio { get; set; }

        public string EstadoCorrelatividad { get; set; }

    }
}
