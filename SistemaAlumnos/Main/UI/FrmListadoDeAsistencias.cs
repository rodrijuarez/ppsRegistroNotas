using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using UTN.SistemaAlumnos.Datos;


namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmListadoDeAsistencias : Form
    {
        public static List<ListadoAsistencias> listado = new List<ListadoAsistencias>();

        public FrmListadoDeAsistencias()
        {
            InitializeComponent();
        }


        private void btn_completo_Click(object sender, EventArgs e)
        {
            //listado = DatosListado.TraerTodos();
            listado.Clear();
            ListadoAsistencias a = new ListadoAsistencias();
            ListadoAsistencias b = new ListadoAsistencias();
            a.descripcionCarrera = "TODO CarreraA";
            a.descripcionMateria = "TODO MateriaA";
            a.apellidoProfesor = "TODO ProfesorA";
            a.nombreProfesor = "TODO ProfesorA";
            a.apellidoAlumno = "TODO AlumnoA";
            a.nombreAlumno = "TODO AlumnoA";
            listado.Add(a);


            b.descripcionCarrera = "TODO CarreraB";
            b.descripcionMateria = "TODO MateriaB";
            b.apellidoProfesor = "TODO ProfesorB";
            b.nombreProfesor = "TODO ProfesorB";
            b.apellidoAlumno = "TODO AlumnoB";
            b.nombreAlumno = "TODO AlumnoB";
            listado.Add(b);

            //Llamada a ReportingServices
            FrmListadoAsistenciasTotal frm = new FrmListadoAsistenciasTotal();
            frm.ShowDialog();
        }

        private void btn_filtrado_Click(object sender, EventArgs e)
        {
            FrmTurno frm = new FrmTurno();
            frm.ShowDialog();
        }

    }
}
