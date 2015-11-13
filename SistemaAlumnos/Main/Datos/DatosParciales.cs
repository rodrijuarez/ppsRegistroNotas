using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;
using System.Data;

namespace UTN.SistemaAlumnos.Datos
{
    public class DatosParciales
    {
            static Database _db = DatabaseFactory.CreateDataBase();

            public static List<AsientoParcial> TraerTodas()
            {
                List<AsientoParcial> lstAlumnos = new List<AsientoParcial>();
                try
                {
                    using (IDataReader dr = _db.ExecuteReader("sp_traerNotasParcial"))
                    {
                        while (dr.Read())
                        {
                            lstAlumnos.Add(new AsientoParcial() { Alu_Nombre = dr["NombreAlumno"].ToString(), 
                                                                  Alu_Apellido = dr["ApeAlumno"].ToString(),
                                                                  Car_Descripcion = dr["DescripCarrera"].ToString(),
                                                                  Prof_Apellido = dr["ApeProf"].ToString(),
                                                                  Prof_Nombre = dr["NombreProf"].ToString(),
                                                                  Mat_Descripcion = dr["DescripcionMat"].ToString() });
                        }
                    }
                    return lstAlumnos;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               
            }
   }
}
