using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    class InscriptosCursar
    {
        public int idTurnosCursar { get; set; }
        public int idLegajo { get; set; }
        public int NotaPrimParcial { get; set; }
        public int NotaSegParcial { get; set; }
        public int PrimerRecTipo { get; set; }
        public int Rec1 { get; set; }
        public int SegRecTipo { get; set; }
        public int Rec2 { get; set; }
        public int TerRecTipo { get; set; }
        public int Rec3 { get; set; }
        public char Estado { get; set; }
        public char EstadoCorrelatividad { get; set; }
    }
}
