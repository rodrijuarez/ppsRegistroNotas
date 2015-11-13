using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class Profesor
    {
        public int IdProfesor { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string DomCalle { get; set; }

        public string DomNro { get; set; }

        public string DomPiso { get; set; }

        public string DomDepto { get; set; }

        public string DomCodPostal { get; set; }

        public int DomProv { get; set; }

        public string DomLocalidad { get; set; }

        public string Mail { get; set; }

        public string Telefono { get; set; }

        public char Estado { get; set; }
    }
}
