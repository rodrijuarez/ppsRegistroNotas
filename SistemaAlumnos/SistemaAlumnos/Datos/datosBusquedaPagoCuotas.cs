using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    public class datosBusquedaPagoCuotas
    {

        static Database _db = DatabaseFactory.CreateDataBase();

        /* public static  busquedaAlumno()
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
         }*/

        public static Alumno TraeALumnoLegajo(string legajo)
        {
            using (IDataReader lector = _db.ExecuteReader("sp_alumnoPorLegajo", legajo))
            {
                return new Alumno()
                {
                    Nombre = (string)lector["Nombres"],
                    Apellido = (string)lector["Apellido"],
                    IdLegajo = lector["idLegajo"].ToString(),
                    Estado = (char)lector["Estado"]
                };
            }

        }




    }
}
