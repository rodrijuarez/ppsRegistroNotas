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
            using (IDataReader dr = _db.ExecuteReader("Alumnos_TxApellido", apellido))
            {

                while (dr.Read())
                {
                    alumnos.Add(new Alumno()
                    {
                        IdAlumno = (int)dr["idAlumno"],
                        IdLegajo = dr["idLegajo"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Nombre = dr["Nombres"].ToString(),
                        Sexo = (int)dr["Sexo"],


                        IdCarrera1 = (DBNull.Value == dr["idCarrera1"]) ? 0 : (int)dr["idCarrera1"],
                        IdCarrera2 = (DBNull.Value == dr["idCarrera2"]) ? 0 : (int)dr["idCarrera2"],
                        IdCarrera3 = (DBNull.Value == dr["idCarrera3"]) ? 0 : (int)dr["idCarrera3"],

                        NumeroDocumentos = (DBNull.Value == dr["NumeroDocumento"]) ? 0 : (int)dr["NumeroDocumento"],
                        TipoDocumento = (DBNull.Value == dr["TipoDocumento"]) ? 0 : (int)dr["TipoDocumento"],
                        DomCalle = (DBNull.Value == dr["DomCalle"])? "" : dr["DomCalle"].ToString(),
                        DomNro = (DBNull.Value == dr["DomNro"]) ? "" : dr["DomNro"].ToString(),
                        //DomPiso = dr["DomPiso"].ToString(),
                        //DomDepto = dr["DomDepto"].ToString(),
                        DomCodPostal = (DBNull.Value == dr["DomCodPostal"]) ? "" : dr["DomCodPostal"].ToString(),
                        DomProv = (DBNull.Value == dr["DomProv"]) ? 0 : (int)dr["DomProv"],
                        DomLocalidad = (DBNull.Value == dr["DomLocalidad"]) ? "" : dr["DomLocalidad"].ToString(),
                        Mail = (DBNull.Value == dr["Mail"]) ? "" : dr["Mail"].ToString(),
                        Telefono = (DBNull.Value == dr["Telefono"]) ? "" : dr["Telefono"].ToString(),
                        //FechaIngreso1 = dr["FechaIngreso1"].ToString(),
                        //FechaIngreso2 = dr["FechaIngreso2"].ToString(),
                        //FechaIngreso3 = dr["FechaIngreso3"].ToString(),
                        //FechaEgreso1 = dr["FechaEgreso1"].ToString(),
                        //FechaEgreso2 = dr["FechaEgreso2"].ToString(),
                        //FechaEgreso3 = dr["FechaEgreso3"].ToString(),
                    });


                }


            }
            return alumnos;

        }
        public static List<Alumno> TraerTodosPorLegajo(string legajo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            int valor = int.Parse(legajo);
            using (IDataReader dr = _db.ExecuteReader("Alumnos_TxLegajo", valor))
            {
                while (dr.Read())
                {
                    alumnos.Add(new Alumno()
                    {
                        IdAlumno = (int)dr["idAlumno"],
                        IdLegajo = dr["idLegajo"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Nombre = dr["Nombres"].ToString(),
                        Sexo = (int)dr["Sexo"],
                        IdCarrera1 = (int)dr["idCarrera1"],
                        IdCarrera2 = (int)dr["idCarrera2"],
                        IdCarrera3 = (int)dr["idCarrera3"],
                        FechaNacimiento = (DateTime)dr["FechaNacim"],
                        NumeroDocumentos = (int)dr["NumeroDocumento"],
                        TipoDocumento = (int)dr["TipoDocumento"],
                        DomCalle = dr["DomCalle"].ToString(),
                        DomNro = dr["DomNro"].ToString(),
                        DomPiso = dr["DomPiso"].ToString(),
                        DomDepto = dr["DomDepto"].ToString(),
                        DomCodPostal = dr["DomCodPostal"].ToString(),
                        DomProv = (int)dr["DomProv"],
                        DomLocalidad = dr["DomLocalidad"].ToString(),
                        Mail = dr["Mail"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        FechaIngreso1 = dr["FechaIngreso1"].ToString(),
                        FechaIngreso2 = dr["FechaIngreso2"].ToString(),
                        FechaIngreso3 = dr["FechaIngreso3"].ToString(),
                        FechaEgreso1 = dr["FechaEgreso1"].ToString(),
                        FechaEgreso2 = dr["FechaEgreso2"].ToString(),
                        FechaEgreso3 = dr["FechaEgreso3"].ToString(),
                        Estado = (char)dr["Estado"],
                        UltFechaEstado = (DateTime)dr["UltFechaEstado"],
                        Trabaja = (bool)dr["Trabaja"],
                        EstadoCivil = (int)dr["EstadiCivil"],
                        LugarNacimiento = dr["LugarNacimiento"].ToString(),
                        FechaEgresoSecundario = (DateTime)dr["FechaEgresoSecundario"]
                    });
                }
            }
            return alumnos;

        }
        public static DataTable GetTablaporApellido(string valor)
        {
            DataTable dt = new DataTable("PorApellido");
            dt.Columns.Add("idAlumno", typeof(int));
            dt.Columns.Add("idLegajo", typeof(int));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Nombres", typeof(string));
            dt.Columns.Add("Sexo", typeof(int));
            dt.Columns.Add("idCarrera1", typeof(int));
            dt.Columns.Add("idCarrera2", typeof(int));
            dt.Columns.Add("idCarrera3", typeof(int));
            dt.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dt.Columns.Add("NumeroDocumento", typeof(int));
            dt.Columns.Add("TipoDocumento", typeof(int));
            dt.Columns.Add("DomCalle", typeof(string));
            dt.Columns.Add("DomNro", typeof(string));
            dt.Columns.Add("DomPiso", typeof(string));
            dt.Columns.Add("DomDepto", typeof(string));
            dt.Columns.Add("DomCodPostal", typeof(string));
            dt.Columns.Add("Domicilio Provincia", typeof(int));
            dt.Columns.Add("Domicilio Localidad", typeof(string));
            dt.Columns.Add("Mail", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));
            dt.Columns.Add("Fecha Ingreso 1", typeof(string));
            dt.Columns.Add("Fecha Ingreso 2", typeof(string));
            dt.Columns.Add("Fecha Ingreso 3", typeof(string));
            dt.Columns.Add("Fecha Egreso 1", typeof(string));
            dt.Columns.Add("Fecha Egreso 2", typeof(string));
            dt.Columns.Add("Fecha Egreso 3", typeof(string));
            dt.Columns.Add("Estado", typeof(char));
            dt.Columns.Add("Ultima Fecha Estado", typeof(DateTime));
            dt.Columns.Add("Trabaja", typeof(byte));
            dt.Columns.Add("Estadi Civil", typeof(int));
            dt.Columns.Add("Lugar Nacimiento", typeof(string));
            dt.Columns.Add("Fecha Egreso Secundario", typeof(DateTime));

            List<Alumno> lista = TraerTodosPorApellido(valor);
            foreach (Alumno item in lista)
            {
                dt.Rows.Add(item);
            }

            return dt;
        }
        public static DataTable GetTablaporLegajo(string valor)
        {
            DataTable dt = new DataTable("PorLegajo");
            dt.Columns.Add("idAlumno", typeof(int));
            dt.Columns.Add("idLegajo", typeof(int));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Nombres", typeof(string));
            dt.Columns.Add("Sexo", typeof(int));
            dt.Columns.Add("idCarrera1", typeof(int));
            dt.Columns.Add("idCarrera2", typeof(int));
            dt.Columns.Add("idCarrera3", typeof(int));
            dt.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dt.Columns.Add("NumeroDocumento", typeof(int));
            dt.Columns.Add("TipoDocumento", typeof(int));
            dt.Columns.Add("DomCalle", typeof(string));
            dt.Columns.Add("DomNro", typeof(string));
            dt.Columns.Add("DomPiso", typeof(string));
            dt.Columns.Add("DomDepto", typeof(string));
            dt.Columns.Add("DomCodPostal", typeof(string));
            dt.Columns.Add("Domicilio Provincia", typeof(int));
            dt.Columns.Add("Domicilio Localidad", typeof(string));
            dt.Columns.Add("Mail", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));
            dt.Columns.Add("Fecha Ingreso 1", typeof(string));
            dt.Columns.Add("Fecha Ingreso 2", typeof(string));
            dt.Columns.Add("Fecha Ingreso 3", typeof(string));
            dt.Columns.Add("Fecha Egreso 1", typeof(string));
            dt.Columns.Add("Fecha Egreso 2", typeof(string));
            dt.Columns.Add("Fecha Egreso 3", typeof(string));
            dt.Columns.Add("Estado", typeof(char));
            dt.Columns.Add("Ultima Fecha Estado", typeof(DateTime));
            dt.Columns.Add("Trabaja", typeof(byte));
            dt.Columns.Add("Estadi Civil", typeof(int));
            dt.Columns.Add("Lugar Nacimiento", typeof(string));
            dt.Columns.Add("Fecha Egreso Secundario", typeof(DateTime));

            List<Alumno> lista = TraerTodosPorLegajo(valor);
            foreach (Alumno item in lista)
            {
                dt.Rows.Add(item);
            }

            return dt;
        }




    }
}
