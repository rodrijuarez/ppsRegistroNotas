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

        public static Alumno TraeALumnoLegajo(string legajo)
        {
            
            try
            {
                IDataReader lector = _db.ExecuteReader("sp_alumnoPorLegajo", legajo);
                Alumno elAlu = new Alumno();

                while(lector.Read())
                {
                    elAlu.Nombre = (string)lector["Nombres"];
                    elAlu.Apellido = (string)lector["Apellido"];
                    elAlu.IdLegajo = (string)lector["idLegajo"];
                }
                return elAlu;
            }
            catch (Exception ex)
            {
                throw new UTN.Framework.Data.DataException(ex.ToString());
            }

        }

        public static List<Alumno> TraerALumnoApellido(string apellido)
        { 
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                IDataReader lector = _db.ExecuteReader("sp_alumnoPorApellido", apellido);

                while (lector.Read())
                {
                    alumnos.Add(new Alumno()
                    {
                        Apellido = (string)lector["Apellido"],
                        Nombre = (string)lector["Nombre"],
                        IdLegajo = (string)lector["idLegajo"],

                    });
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                throw new UTN.Framework.Data.DataException(ex.ToString());
        }
        }

        public static Chequera TraerChequera(string legajo)
        {
            try
            {
                IDataReader lector = _db.ExecuteReader("sp_TraerChequera", legajo);
                Entidades.Chequera lachequera = new Chequera();
                
               
                while (lector.Read())
                {
                    
                        lachequera.ImportePago1 = (decimal)lector["ImportePago1"];
                        lachequera.FechaPago1 = (DateTime)lector["FechaPago1"];
                    
                    
                        lachequera.ImportePago2 = (decimal)lector["ImportePago2"];
                        lachequera.FechaPago2 = (DateTime)lector["FechaPago2"];
                    
                        lachequera.ImportePago3 = (decimal)lector["ImportePago3"];
                        lachequera.FechaPago3 = (DateTime)lector["FechaPago3"];
                    
                        lachequera.ImportePago4 = (decimal)lector["ImportePago4"];
                        lachequera.FechaPago4 = (DateTime)lector["FechaPago4"];
                    
                        lachequera.ImportePago5 = (decimal)lector["ImportePago5"];
                        lachequera.FechaPago5 = (DateTime)lector["FechaPago5"];
                    
                }
                return lachequera;
                
            }
            catch (Exception ex)
            {
                throw new UTN.Framework.Data.DataException(ex.ToString());
            }
        }

        public static void HacerPago(Chequera laChequera, Alumno elAlumno)
        {
            try
            {
                _db.ExecuteReader("sp_insertarChequeras",
                    laChequera.idLegajo,
                    laChequera.AnioLectivo,
                    laChequera.Cuatrimestre,

                    laChequera.ImportePago1,
                    laChequera.ImportePago2,
                    laChequera.ImportePago3,
                    laChequera.ImportePago4,
                    laChequera.ImportePago5,

                    laChequera.FechaPago1,                    
                    laChequera.FechaPago2,                    
                    laChequera.FechaPago3,                    
                    laChequera.FechaPago4,                     
                    laChequera.FechaPago5,
                     
                    "deudor");

            }
            catch (Exception ex)
            {
                throw new UTN.Framework.Data.DataException(ex.ToString());
            }


        }






    }
}
