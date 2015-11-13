using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public int IdCarrera { get; set; }
        public string Descripcion { get; set; }
        public int CargaHoraria { get; set; }
        public int Cuatrimestre { get; set; }
    }
}
