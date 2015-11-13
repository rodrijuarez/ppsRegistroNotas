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
    public class DatosCarreras
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<Carrera> TraerTodas()
        {
            List<Carrera> carreras = new List<Carrera>();
            using (IDataReader dr = _db.ExecuteReader("Carreras_TT"))
            {
                while (dr.Read())
                {
                    carreras.Add(new Carrera() { Id = (int)dr["idCarrera"], Descripcion = dr["descripcion"].ToString() });
                }
            }
            return carreras;
        }
            
        public static void Existe(int idCarrera)
        {
            // Verifica si existe una carrera con el Id dado
        }
    }
}
