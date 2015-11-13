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
    public class DatosAlumno
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<Alumno> TraerTodosPorApellido(string apellido)
        {
            List<Alumno> alumnos = new List<Alumno>();
            using (IDataReader dr = _db.ExecuteReader("Alumnos_TxApellido",apellido))
            {
                while (dr.Read())
                {
                    alumnos.Add(new Alumno() {  
                                               IdLegajo = dr["idLegajo"].ToString(), 
                                               Apellido = dr["Apellido"].ToString(), 
                                               Nombre = dr["Nombres"].ToString(), 
                                               Sexo = (int)dr["Sexo"],
                                               //IdCarrera1 = (int)dr["idCarrera1"], 
                                               //IdCarrera2 = (int)dr["idCarrera2"], 
                                               //IdCarrera3 = (int)dr["idCarrera3"], 
                                               //FechaNacimiento =(DateTime)dr["FechaNacim"],
                                               //NumeroDocumentos = (int)dr["NumeroDocumento"],
                                               //TipoDocumento = (int)dr["TipoDocumento"],
                                               //DomCalle = dr["DomCalle"].ToString(),
                                               //DomNro = dr["DomNro"].ToString(),
                                               //DomPiso = dr["DomPiso"].ToString(),
                                               //DomDepto = dr["DomDepto"].ToString(),
                                               //DomCodPostal = dr["DomCodPostal"].ToString(),
                                               //DomProv = (int)dr["DomProv"],
                                               //DomLocalidad = dr["DomLocalidad"].ToString(),
                                               //Mail = dr["Mail"].ToString(),
                                               //Telefono = dr["Telefono"].ToString(),
                                               //FechaIngreso1 = dr["FechaIngreso1"].ToString(),
                                               //FechaIngreso2 = dr["FechaIngreso2"].ToString(),
                                               //FechaIngreso3 = dr["FechaIngreso3"].ToString(),
                                               //FechaEgreso1 = dr["FechaEgreso1"].ToString(),
                                               //FechaEgreso2 = dr["FechaEgreso2"].ToString(),
                                               //FechaEgreso3 = dr["FechaEgreso3"].ToString(),
                                               //Estado =(char)dr["Estado"], 
                                               //UltFechaEstado = (DateTime)dr["UltFechaEstado"],
                                               //Trabaja = (byte)dr["Trabaja"],
                                               //EstadoCivil = (int)dr["EstadoCivil"],
                                               //LugarNacimiento = dr["LugarNacimiento"].ToString(),
                                               //FechaEgresoSecundario = (DateTime)dr["FechaEgresoSecundario"]
                    });
               }
             }
            return alumnos;
           
        }
        public static List<Alumno> TraerTodosPorLegajo(string legajo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            int valor = int.Parse(legajo);
            using (IDataReader dr = _db.ExecuteReader("Alumnos_TxLegajo",valor))
            {
                while (dr.Read())
                {
                    alumnos.Add(new Alumno()
                    {
                        
                        IdLegajo = dr["idLegajo"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Nombre = dr["Nombres"].ToString(),
                        Sexo = (int)dr["Sexo"],
                        //IdCarrera1 = (int)dr["idCarrera1"],
                        //IdCarrera2 = (int)dr["idCarrera2"],
                        //IdCarrera3 = (int)dr["idCarrera3"],
                        //FechaNacimiento = (DateTime)dr["FechaNacim"],
                        //NumeroDocumentos = (int)dr["NumeroDocumento"],
                        //TipoDocumento = (int)dr["TipoDocumento"],
                        //DomCalle = dr["DomCalle"].ToString(),
                        //DomNro = dr["DomNro"].ToString(),
                        //DomPiso = dr["DomPiso"].ToString(),
                        //DomDepto = dr["DomDepto"].ToString(),
                        //DomCodPostal = dr["DomCodPostal"].ToString(),
                        //DomProv = (int)dr["DomProv"],
                        //DomLocalidad = dr["DomLocalidad"].ToString(),
                        //Mail = dr["Mail"].ToString(),
                        //Telefono = dr["Telefono"].ToString(),
                        //FechaIngreso1 = dr["FechaIngreso1"].ToString(),
                        //FechaIngreso2 = dr["FechaIngreso2"].ToString(),
                        //FechaIngreso3 = dr["FechaIngreso3"].ToString(),
                        //FechaEgreso1 = dr["FechaEgreso1"].ToString(),
                        //FechaEgreso2 = dr["FechaEgreso2"].ToString(),
                        //FechaEgreso3 = dr["FechaEgreso3"].ToString(),
                        //Estado = (char)dr["Estado"],
                        //UltFechaEstado = (DateTime)dr["UltFechaEstado"],
                        //Trabaja = (byte)dr["Trabaja"],
                        //EstadoCivil = (int)dr["EstadiCivil"],
                        //LugarNacimiento = dr["LugarNacimiento"].ToString(),
                        //FechaEgresoSecundario = (DateTime)dr["FechaEgresoSecundario"]
                    });
                }
            }
            return alumnos;

        }
       




    }
}
