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
        static Database _db = DatabaseFactory.CreateDataBase();

        public static List<TurnoCursar> TraerTurnoCursarPorMateria(int idMateria)
        {
            List<TurnoCursar> listaTurnosCursar = new List<TurnoCursar>();
            using (IDataReader dr = _db.ExecuteReader("TurnosCursar_TxIdMateria", idMateria.ToString()))
            {
                while (dr.Read())
                {
                    listaTurnosCursar.Add(new TurnoCursar() { idTurnosCursar = (int)dr["idTurnosCursar"], AnioLectivo = (int)dr["AnioLectivo"], Cuatrimestre = (int)dr["Cuatrimestre"], IdCarrera = (int)dr["IdCarrera"], IdMateria = (int)dr["IdMateria"], Turno = (string)dr["Turno"], Division = (string)dr["Division"], DiaDictado1 = (string)dr["DiaDicatado1"], DiaDictado2 = (string)dr["DiaDicatado2"], Duracion1 = (string)dr["Duracion"], Duracion2 = (string)dr["Duracion2"],IdProfesor=(int)dr["IdProfesor"] });
                }
            }
            return listaTurnosCursar;
        }

        public static void Guardar(TurnoCursar t)
        {
            _db.ExecuteNonQuery("TurnosCursar_A", new object[] { t.AnioLectivo,t.Cuatrimestre,t.IdCarrera,t.IdMateria,t.Turno,t.Division,
            t.DiaDictado1,t.DiaDictado2,t.Duracion1,t.Duracion2,t.IdProfesor});                           
        }


        public static void Modificar(TurnoCursar t)
        {
            _db.ExecuteNonQuery("TurnosCursar_M", new object[] {t.idTurnosCursar,t.AnioLectivo,t.Cuatrimestre,t.IdCarrera,t.IdMateria,t.Turno,t.Division,
            t.DiaDictado1,t.DiaDictado2,t.Duracion1,t.Duracion2,t.IdProfesor});                           
        }
    }
}
