using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    public class DatosActas
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static Actas TraerPorFolioYTomo(int folio, int tomo)
        {
            Actas UnActita = new Actas();
            using (IDataReader dr = _db.ExecuteReader("Actas_TxIds",new object[]{ folio, tomo }))
            {
                while (dr.Read())
                {
                   UnActita = new Actas(){
                       IdTomo = (int)dr["Nro. de Tomo"],
                        IdFolio = (int)dr["Nro. de Folio"],
                        Fecha = (DateTime) dr["Fecha"],
                        IdCarrera = dr["Carrera"].ToString(),
                        IdMateria = dr["Materia"].ToString(),
                        Inscriptos = (int)dr["Inscriptos"],
                        Estado = dr["Estado"].ToString(),
                        Aprobados = (int)dr["Cant. de Aprobados"],
                        Ausentes = (int)dr["Cant. de Ausentes"],
                        Desaprobados = (int)dr["Cant. de Desaprobados"],
                        IdUsuarioResponsable = (int)dr["Usuario Responsable"],
                        FechaIngreso = (DateTime)dr["Fecha de Ingreso"]
                    };
                }
            }
            return UnActita;
        }
    }
}
