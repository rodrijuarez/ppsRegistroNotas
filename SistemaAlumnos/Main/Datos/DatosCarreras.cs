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
        private Database dataBase;

        public DatosCarreras()
        {
                dataBase = DatabaseFactory.CreateDataBase();
        }

        public List<Carrera> TraerTodas()
        {
            List<Carrera> carreras = new List<Carrera>();
            using (IDataReader reader = dataBase.ExecuteReader("sp_carreras_traer"))
            {
                while (reader.Read())
                {
                    carreras.Add(new Carrera() { 
                        Id = (int)reader["idCarrera"], 
                        Descripcion = reader["descripcion"].ToString() });
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
