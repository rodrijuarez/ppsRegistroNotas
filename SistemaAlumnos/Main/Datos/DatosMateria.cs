using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    public class DatosMateria
    {
        private Database database;

        public DatosMateria()
        {
            database = DatabaseFactory.CreateDataBase();
        }

        public List<Materia> TraerMateriasPorIdCarrera(int carrera)
        {
            List<Materia> materias = new List<Materia>();
            using (IDataReader reader = database.ExecuteReader("sp_materias_traerxidCarrera", carrera))
            {
                while (reader.Read())
                {
                    materias.Add(new Materia() { 
                        IdMateria = (int)reader["idmateria"], 
                        IdCarrera = (int)reader["idcarrera"], 
                        Descripcion = reader["descripcion"].ToString(), 
                        CargaHoraria = (int)reader["cargahoraria"], 
                        Cuatrimestre = (int)reader["cuatrimestre"] 
                    });
                }
            }
            return materias;
        }
    }
}
