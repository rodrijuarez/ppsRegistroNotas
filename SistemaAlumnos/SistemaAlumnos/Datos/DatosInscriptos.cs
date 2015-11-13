using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    /// <summary>
    /// Código de Ejemplo simplemente para que se tome como punto de partida 
    /// al escribir el acceso a datos utilizando el UTN Framework
    /// </summary>
    public class DatosInscriptos
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<Inscriptos> TraerTodos()
        {
            List<Inscriptos> inscriptos = new List<Inscriptos>();
            using (IDataReader dr = _db.ExecuteReader("Inscriptoscursar_TT"))
            {
                while (dr.Read())
                {
                    inscriptos.Add(new Inscriptos() { IdTurnosCursar = (int)dr["idTurnosCursar"], IdLegajo = (int)dr["idLegajo"]});
                }
            }
            return inscriptos;
        }

       
    }
}
