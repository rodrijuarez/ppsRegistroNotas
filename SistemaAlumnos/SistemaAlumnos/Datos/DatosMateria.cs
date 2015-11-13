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
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<Materia> TraerMateriasPorCarrera()
        {
            List<Materia> materias = new List<Materia>();
            using (IDataReader dr = _db.ExecuteReader("Materias_TxIdCarrera"))
            {
                while (dr.Read())
                {
                    materias.Add(new Materia() { IdMateria = (int)dr["idmateria"], IdCarrera = (int)dr["idcarrera"], Descripcion = dr["descripcion"].ToString(), CargaHoraria = (int)dr["cargahoraria"], Cuatrimestre = (int)dr["cuatrimestre"] });
                }
            }
            return materias;
        }
    }
}
