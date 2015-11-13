using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.UI;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //comentario de prueba check in / check out
        }

        private void cargarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioTurnos frm = new FormularioTurnos();
            frm.ShowDialog();
        }

        private void listaDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmListadoDeAsistencias = new FrmListadoDeAsistencias();
            frmListadoDeAsistencias.ShowDialog();
        }

        private void abrirFormPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrueba frm = new formPrueba();

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //
        }

        private void pagoDeCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new RegistrarPagoCuota())
            {
                form.ShowDialog();
            }

        }

        private void turnosDeExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new RegistrarTurnoExamen())
            {
                form.ShowDialog();
            }
        }

        private void controlDeCorrelativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         


        }

        private void datosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ConsultarDatosAcademicos())
            {
                form.ShowDialog();
            }
        }

        private void consultaActasExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ConsultaActasExamen())
            {
                form.ShowDialog();
            }
        }

        private void ProbandoXD(object sender, EventArgs e)
        {
            // no se ni que estoy haciendo nomas copipastie un poquito
            using (var form = new RegistrarPagoCuota())
            {
                form.ShowDialog();
            }

        }



        private void registrarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new RegistrarProfesor())
            {
                form.ShowDialog();
            }
        }


        private void consultaAlumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsultas consultas = new FrmConsultas();
            consultas.MdiParent = this;
            consultas.Show();
        }

        private void registroNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new IntRegisNotas())
            {
                form.ShowDialog();
            }
        }

        private void registrarTurnosCursadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmRegistrarTurnosCursada())
            {
                form.ShowDialog();
            }
        }

        private void agregarTurnosCursadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarTurnosCursada formRegistrar = new frmRegistrarTurnosCursada();
            formRegistrar.ShowDialog();
        }

        private void listadoDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FrmListadoDeAsistencias())
            {
                form.ShowDialog();
            }
        }

        private void listaNotasDeParcialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*using (var form = new ListaNotasParciales(@"C:\Users\alumno.LAB5PC03\Desktop\Nueva carpeta\SistemaAlumnos\Main\UI\Report1.rdlc", UTN.SistemaAlumnos.Datos.DatosParciales.TraerTodas(), "Reporte"))
            {
                form.ShowDialog();
            }*/
        }
    }
}
