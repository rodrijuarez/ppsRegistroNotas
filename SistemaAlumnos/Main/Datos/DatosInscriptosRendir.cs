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
    public class DatosInscriptosRendir
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<InscriptosRendir> TraerTodas()
        {
            List<InscriptosRendir> InscriptosRendir = new List<InscriptosRendir>();
            using (IDataReader dr = _db.ExecuteReader("SP_Traer_Todo_InscriptosRendir"))
            {
                while (dr.Read())
                {
                    InscriptosRendir.Add(new InscriptosRendir()
                    {
                        IdTurnosRendir = (int)dr["idTurnosRendir"],
                        IdLegajo = dr["idLegajo"].ToString(),
                        Estado = dr["Estado"].ToString(),
                        FechaElegida = (dr["FechaElegida"]).ToString(),
                        IdTomo = (int)dr["idTomo"],
                        IdFolio = (int)dr["idFolio"],
                        EstadoCorrelatividad = dr["EstadoCorrelatividad"].ToString()
                    });
                }
            }
            return InscriptosRendir;
        }
    }
}
