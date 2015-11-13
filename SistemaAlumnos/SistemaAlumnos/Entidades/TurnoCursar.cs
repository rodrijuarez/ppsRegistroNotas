using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class TurnoCursar
    
    {
        public int AnioLectivo  {get; set;}
        public int Cuatrimestre {get; set;}
        public int IdCarrera {get; set;}
        public int IdMateria {get; set;}
        public string Turno {get; set;}
        public string Division {get; set;}
        public string DiaDictado1 {get; set;}
        public string DiaDictado2 {get; set;}
        public string Duracion1 { get; set; }
        public string Duracion2 {get; set;}
        public int IdProfesor {get; set;}



    }
}
