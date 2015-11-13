using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
    public class DatosTurnoCursar
    {
        static Database database = DatabaseFactory.CreateDataBase();

        public static List<TurnoCursar> TraerTurnoCursarPorIdMateria(int idMateria)
        {
            List<TurnoCursar> listaTurnosCursar = new List<TurnoCursar>();
            using (IDataReader reader = database.ExecuteReader("sp_turnosCursar_traerxidMateria", idMateria))
            {
                while (reader.Read())
                {
                    listaTurnosCursar.Add(new TurnoCursar() {
                        idTurnosCursar = (int)reader["idTurnosCursar"],
                        AnioLectivo = (int)reader["AnioLectivo"],
                        Cuatrimestre = (int)reader["Cuatrimestre"],
                        IdCarrera = (int)reader["IdCarrera"],
                        IdMateria = (int)reader["IdMateria"],
                        Turno = (string)reader["Turno"],
                        Division = (string)reader["Division"],
                        DiaDictado1 = (string)reader["DiaDictado1"],
                        DiaDictado2 = (string)reader["DiaDictado2"],
                        Duracion1 = (string)reader["Duracion"],
                        Duracion2 = (string)reader["Duracion2"],
                        IdProfesor =(int)reader["IdProfesor"] });
                }
            }
            return listaTurnosCursar;
        }

        public static List<TurnoCursar> TraerTurnoCursarPorIdMateriaYTurno(int idMateria,string turno)
        {
            List<TurnoCursar> listaTurnosCursar = new List<TurnoCursar>();
            using (IDataReader reader = database.ExecuteReader("sp_materias_traerxidMateriaxTurno", idMateria,turno))
            {
                while (reader.Read())
                {
                    listaTurnosCursar.Add(new TurnoCursar() {
                        idTurnosCursar = (int)reader["idTurnosCursar"],
                        AnioLectivo = (int)reader["AnioLectivo"],
                        Cuatrimestre = (int)reader["Cuatrimestre"],
                        IdCarrera = (int)reader["IdCarrera"],
                        IdMateria = (int)reader["IdMateria"],
                        Turno = (string)reader["Turno"],
                        Division = (string)reader["Division"],
                        DiaDictado1 = (string)reader["DiaDictado1"],
                        DiaDictado2 = (string)reader["DiaDictado2"],
                        Duracion1 = (string)reader["Duracion"],
                        Duracion2 = (string)reader["Duracion2"],
                        IdProfesor = (int)reader["IdProfesor"]
                    });
                }
            }
            return listaTurnosCursar;
        }

        public static TurnoCursar TraerTurnoCursarFiltrado(int idMateria, string turno,int division)
        {
            List<TurnoCursar> listaTurnosCursar = new List<TurnoCursar>();
            using (IDataReader reader = database.ExecuteReader("sp_materias_traerxidMateriaxTurnoxDivision", idMateria, turno,division))
            {
                while (reader.Read())
                {
                    listaTurnosCursar.Add(new TurnoCursar()
                    {
                        idTurnosCursar = (int)reader["idTurnosCursar"],
                        AnioLectivo = (int)reader["AnioLectivo"],
                        Cuatrimestre = (int)reader["Cuatrimestre"],
                        IdCarrera = (int)reader["IdCarrera"],
                        IdMateria = (int)reader["IdMateria"],
                        Turno = (string)reader["Turno"],
                        Division = (string)reader["Division"],
                        DiaDictado1 = (string)reader["DiaDictado1"],
                        DiaDictado2 = (string)reader["DiaDictado2"],
                        Duracion1 = (string)reader["Duracion"],
                        Duracion2 = (string)reader["Duracion2"],
                        IdProfesor = (int)reader["IdProfesor"]
                    });
                }
            }
            return listaTurnosCursar[0];
        }

        public static void Guardar(TurnoCursar turno)
        {
            database.ExecuteNonQuery("TurnosCursar_A", new object[] { turno.AnioLectivo,turno.Cuatrimestre,turno.IdCarrera,turno.IdMateria,turno.Turno,turno.Division,
            turno.DiaDictado1,turno.DiaDictado2,turno.Duracion1,turno.Duracion2,turno.IdProfesor});                           
        }


        public static void Modificar(TurnoCursar turno)
        {
            database.ExecuteNonQuery("TurnosCursar_M", new object[] {turno.idTurnosCursar,turno.AnioLectivo,turno.Cuatrimestre,turno.IdCarrera,turno.IdMateria,turno.Turno,turno.Division,
            turno.DiaDictado1,turno.DiaDictado2,turno.Duracion1,turno.Duracion2,turno.IdProfesor});                           
        }
    }
}
