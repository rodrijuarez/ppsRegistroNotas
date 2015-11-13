using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    public class DatosInscriptosCursar
    {
        private Database database;

        public DatosInscriptosCursar()
        {
            database = DatabaseFactory.CreateDataBase();
        }


        public List<InscriptosCursar> TraerPorIdTurnoCursarYLegajo(int idTurnosCursar, int legajo)
        {
            List<InscriptosCursar> inscriptosCursar = new List<InscriptosCursar>();
            using (IDataReader dr = database.ExecuteReader("sp_inscriptosCursar_traerxidLegajo", idTurnosCursar, legajo))
            {   
                //Revisar que la idLegajo esta guardada en la base de datos como un char y en nuestro programa es un int.
                while (dr.Read())
                {
                    InscriptosCursar inscriptoCursar = new InscriptosCursar()
                    {
                        idTurnosCursar = (int)dr["idTurnosCursar"],
                        idLegajo = dr["idLegajo"] == System.DBNull.Value ? 0 : int.Parse((string)dr["idLegajo"]),
                        NotaPrimParcial = dr["NotaPrimParcial"] == System.DBNull.Value ? 0 : (int)dr["NotaPrimParcial"],
                        NotaSegParcial = dr["NotaSegParcial"] == System.DBNull.Value ? 0 : (int)dr["NotaSegParcial"],
                        PrimerRecTipo = dr["PrimerRecTipo"] == System.DBNull.Value ? 0 : (int)dr["PrimerRecTipo"],
                        Rec1 = dr["Rec1"] == System.DBNull.Value ? 0 : (int)dr["Rec1"],
                        SegRecTipo = dr["SegRecTipo"] == System.DBNull.Value ? 0 : (int)dr["SegRecTipo"],
                        Rec2 = dr["Rec2"] == System.DBNull.Value ? 0 : (int)dr["Rec2"],
                        TerRecTipo = dr["TerRecTipo"] == System.DBNull.Value ? 0 : (int)dr["TerRecTipo"],
                        Rec3 = dr["Rec3"] == System.DBNull.Value ? 0 : (int)dr["Rec3"],
                        //Estado = dr["Estado"] == System.DBNull.Value ? ' ' :(char)dr["Estado"],
                        //EstadoCorrelatividad = dr["EstadoCorrelatividad"] == System.DBNull.Value ? ' ' : (char)dr["EstadoCorrelatividad"]
                    };
                    inscriptoCursar.alumno = new Alumno()
                    {
                        IdAlumno = (int)dr["idAlumno"],
                        IdLegajo = dr["idLegajo"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Nombre = dr["Nombres"].ToString(),
                        Sexo = (int)dr["Sexo"]
                    };
                    inscriptosCursar.Add(inscriptoCursar);
                }
            }
            return inscriptosCursar;
        }



        public List<InscriptosCursar> TraerPorIdTurnoCursar(int idTurnosCursar)
        {
            List<InscriptosCursar> inscriptosCursar = new List<InscriptosCursar>();
            using (IDataReader dr = database.ExecuteReader("sp_inscriptosCursar_traer", idTurnosCursar))
            {
                //Revisar que la idLegajo esta guardada en la base de datos como un char y en nuestro programa es un int.
                while (dr.Read())
                {
                    InscriptosCursar inscriptoCursar = new InscriptosCursar()
                    {
                        idTurnosCursar = (int)dr["idTurnosCursar"],
                        idLegajo = dr["idLegajo"] == System.DBNull.Value ? 0 : int.Parse((string)dr["idLegajo"]),
                        NotaPrimParcial = dr["NotaPrimParcial"] == System.DBNull.Value ? 0 : (int)dr["NotaPrimParcial"],
                        NotaSegParcial = dr["NotaSegParcial"] == System.DBNull.Value ? 0 : (int)dr["NotaSegParcial"],
                        PrimerRecTipo = dr["PrimerRecTipo"] == System.DBNull.Value ? 0 : (int)dr["PrimerRecTipo"],
                        Rec1 = dr["Rec1"] == System.DBNull.Value ? 0 : (int)dr["Rec1"],
                        SegRecTipo = dr["SegRecTipo"] == System.DBNull.Value ? 0 : (int)dr["SegRecTipo"],
                        Rec2 = dr["Rec2"] == System.DBNull.Value ? 0 : (int)dr["Rec2"],
                        TerRecTipo = dr["TerRecTipo"] == System.DBNull.Value ? 0 : (int)dr["TerRecTipo"],
                        Rec3 = dr["Rec3"] == System.DBNull.Value ? 0 : (int)dr["Rec3"],
                        //Estado = dr["Estado"] == System.DBNull.Value ? ' ' : (char)dr["Estado"],
                        //EstadoCorrelatividad = dr["EstadoCorrelatividad"] == System.DBNull.Value ? ' ' : (char)dr["EstadoCorrelatividad"]
                    };
                    inscriptoCursar.alumno = new Alumno()
                    {
                        IdAlumno = (int)dr["idAlumno"],
                        IdLegajo = dr["idLegajo"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Nombre = dr["Nombres"].ToString(),
                        Sexo = (int)dr["Sexo"]
                    };
                    inscriptosCursar.Add(inscriptoCursar);
                }
            }
            return inscriptosCursar;

        }

        public int TraerIdTurno(string Turno)
        {
            int idTurno = 0;
            using (IDataReader dr = database.ExecuteReader("InscriptosCursar_TxTurno", Turno))
            {
                while (dr.Read())
                {
                    idTurno = (int)dr["idTurnosCursar"];
                }
            }
            return idTurno;
        }



        public List<InscriptosCursar> Actualizar(InscriptosCursar inscriptoCursar)
        {
            List<InscriptosCursar> inscriptosCursar = new List<InscriptosCursar>();
            using (IDataReader dr = database.ExecuteReader("sp_inscriptosCursar_traer",
                inscriptoCursar.idTurnosCursar,
                inscriptoCursar.idLegajo,
                inscriptoCursar.NotaPrimParcial,
                inscriptoCursar.NotaSegParcial,
                inscriptoCursar.PrimerRecTipo,
                inscriptoCursar.Rec1,
                inscriptoCursar.SegRecTipo,
                inscriptoCursar.Rec2,
                inscriptoCursar.TerRecTipo,
                inscriptoCursar.Rec3))
            {
            }
            return inscriptosCursar;

        }
    }
}
