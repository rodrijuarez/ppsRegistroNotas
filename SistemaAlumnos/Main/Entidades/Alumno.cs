using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class Alumno
    {
        public int IdAlumno { get; set; }

        public string IdLegajo { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public int Sexo { get; set; }

        public int IdCarrera1 {get;set;}

        public int IdCarrera2 { get; set; }

        public int IdCarrera3 { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int NumeroDocumentos { get; set; }

        public int TipoDocumento { get; set; }

        public string DomCalle { get; set; }

        public string DomNro { get; set; }

        public string DomPiso { get; set; }

        public string DomDepto { get; set; }

        public string DomCodPostal { get; set; }

        public int DomProv { get; set; }

        public string DomLocalidad { get; set; }

        public string Mail { get; set; }

        public string Telefono { get; set; }

        public string FechaIngreso1 { get; set; }
        public string FechaIngreso2 { get; set; }
        public string FechaIngreso3 { get; set; }

        public string FechaEgreso1 { get; set; }
        public string FechaEgreso2 { get; set; }
        public string FechaEgreso3 { get; set; }

        public char Estado { get; set; }

        public DateTime UltFechaEstado { get; set; }

        public bool Trabaja { get; set; }

        public int EstadoCivil { get; set; }

        public string LugarNacimiento { get; set; }

        public DateTime FechaEgresoSecundario { get; set; }



    }
}
