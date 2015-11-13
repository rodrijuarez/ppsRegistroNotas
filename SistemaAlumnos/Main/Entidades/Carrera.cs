using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    /// <summary>
    /// Código de Ejemplo simplemente para que se tome como punto de partida 
    /// al escribir las entidades que se persistirán en la BBDD utilizando el UTN Framework
    /// ultimas materias en la unt -fra.
    /// </summary>

    public class Carrera
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
