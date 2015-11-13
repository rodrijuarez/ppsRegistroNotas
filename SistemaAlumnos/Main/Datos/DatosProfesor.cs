using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    public class DatosProfesor
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<Profesor> TraerTodas()
        {
            List<Profesor> profesores = new List<Profesor>();
            using (IDataReader dr = _db.ExecuteReader("Profesores_T"))
            {
                while (dr.Read())
                {
                    profesores.Add(new Profesor()
                    {
                        IdProfesor = (int)dr["idProfesor"],
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }
            return profesores;
        }
    }
}
