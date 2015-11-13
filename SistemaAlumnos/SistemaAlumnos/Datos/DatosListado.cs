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
    public class DatosListado
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<ListadoAsistencias> TraerTodos()
        {
            List<ListadoAsistencias> ListadoAsistencias = new List<ListadoAsistencias>();
            using (IDataReader dr = _db.ExecuteReader("ListadoAsistencia_TT"))
            {
                while (dr.Read())
                {
                    ListadoAsistencias.Add(new ListadoAsistencias() { 
                        descripcionCarrera = dr["Carrera"].ToString(),
                        descripcionMateria = dr["Materia"].ToString(),
                        apellidoProfesor   = dr["Apellido Profe."].ToString(),
                        nombreProfesor     = dr["Nombre Profe."].ToString(),
                        apellidoAlumno     = dr["Apellido Alumno"].ToString(),
                        nombreAlumno       = dr["Nombre Alumno"].ToString(),
                    });
                }
            }
            return ListadoAsistencias;
        }

       
    }
}
