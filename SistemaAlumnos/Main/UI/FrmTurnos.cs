using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;
using UTN.SistemaAlumnos.Datos;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmTurnos : Form
    {
        private TurnoCursar turno; 
        private List<Profesor> profesores;

        public TurnoCursar Turno
        {
            get { return this.turno; }
            set { this.turno=value;}
        }
        public FrmTurnos()
        {
            InitializeComponent();
            TurnoCursar turno = new TurnoCursar();
            turno.idTurnosCursar = 0;

            this.cmbTurno.Items.Add("m");
            this.cmbTurno.Items.Add("n");

            this.cmbDiados.Items.Add("lu");
            this.cmbDiados.Items.Add("ma");
            this.cmbDiados.Items.Add("mi");
            this.cmbDiados.Items.Add("ju");
            this.cmbDiados.Items.Add("vi");
            this.cmbDiados.Items.Add("sa");
            

            this.cmbDia.Items.Add("lu");
            this.cmbDia.Items.Add("ma");
            this.cmbDia.Items.Add("mi");
            this.cmbDia.Items.Add("ju");
            this.cmbDia.Items.Add("vi");
            this.cmbDia.Items.Add("sa");


            this.cmbDuracion1.Items.Add("C");
            this.cmbDuracion1.Items.Add("M");

            this.cmbDuracion2.Items.Add("C");
            this.cmbDuracion2.Items.Add("M");
            

            this.profesores = DatosProfesor.TraerTodas();
            
        }

        public FrmTurnos(TurnoCursar tc):this()
        {
            this.turno.idTurnosCursar = tc.idTurnosCursar;

            this.txtDivision.Text = tc.Division;
            this.cmbDuracion1.SelectedValue = tc.Duracion1;
            this.cmbDuracion2.SelectedValue = tc.Duracion2;
            this.cmbDia.SelectedValue = tc.DiaDictado1;
            this.cmbDiados.SelectedValue = tc.DiaDictado2;
            this.cmbProfesor.SelectedValue = tc.IdProfesor;
            this.cmbTurno.SelectedValue = tc.Turno;
        }

        private void Profesor_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            turno.Division = (string)this.cmbTurno.SelectedValue;
            turno.DiaDictado1 = (string)this.cmbDia.SelectedValue;
            turno.DiaDictado2 = (string)this.cmbDiados.SelectedValue;
            turno.Duracion1 = (string)this.cmbDuracion1.SelectedValue;
            turno.Duracion2 = (string)this.cmbDuracion2.SelectedValue;
            turno.Turno = (string)this.cmbTurno.SelectedValue;
            turno.IdProfesor = (int)this.cmbProfesor.SelectedValue;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;            
        }
    }
}
