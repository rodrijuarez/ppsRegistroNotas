using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmTurnos : Form
    {
        public FrmTurnos(int cuatrimestre, List<Profesor> profesores, int idMateria, int idCarrera)
        {
            InitializeComponent();
            this._turnocursar = new TurnoCursar();
            foreach (Profesor p in profesores)
            {
                this.cmbProfesor.Items.Add(p);
            }

        }
        private TurnoCursar _turnocursar;
        public TurnoCursar TurnoCursar
        {
            get { return this._turnocursar;}
            set { this._turnocursar = value;}
        }
        public FrmTurnos(TurnoCursar tc,int cuatrimestre, List<Profesor> profesores, int idMateria, int idCarrera):this(cuatrimestre,profesores,idMateria,idCarrera)
        {          
            
            this.txtDivision.Text = tc.Division;
            this.txtDuracion.Text= tc.Duracion1;
            this.txtDuracionDos.Text=tc.Duracion2;
            this.cmbDia.SelectedValue=tc.DiaDictado1;
            this.cmbDiados.SelectedValue = tc.DiaDictado2;
            
            
                        
        }
        private void Profesor_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
            this._turnocursar.AnioLectivo = DateTime.Now.Year;
           
            
            this._turnocursar.Cuatrimestre= 1;
            this._turnocursar.DiaDictado1= cmbDia.SelectedValue.ToString();
            this._turnocursar.DiaDictado2 = cmbDiados.SelectedValue.ToString();
            this._turnocursar.Division = this.txtDivision.Text;
            this._turnocursar.Duracion1 = this.txtDuracion.Text;
            this._turnocursar.Duracion2 = this.txtDuracionDos.Text; 
            
            
           
            this.DialogResult = DialogResult.OK;
               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
