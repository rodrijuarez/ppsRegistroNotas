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
    public class DatosMateriaDivision
    {

        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<MateriaDivision> TraerMateriasDivisionxTurno(string turno)
        {
            List<MateriaDivision> listaMateriaDivision = new List<MateriaDivision>();

            using (IDataReader dr = _db.ExecuteReader("MateriaDivision_TxTurno", turno))
            {
                while (dr.Read())
                {
                    listaMateriaDivision.Add(new MateriaDivision()
                    {
                        idMateria = (int)dr["IdMateria"],
                        descripcion = dr["Materia"].ToString(),
                        division = dr["Division"].ToString()
            
                        //La query del Store Procedure debe ser así:
                        //SELECT DISTINCT dbo.Materias.IdMateria dbo.Materias.descripcion dbo.TurnosCursar.division
                        //      FROM dbo.TurnosCursar, dbo.Materias
                        //      WHERE dbo.TurnosCursar.Turno     = @turno
                        //        AND dbo.TurnosCursar.IdMateria = dbo.Materias.IdMateria;
            
                    });
                }
            }

            return listaMateriaDivision;
        }

    }
}
