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
using UTN.SistemaAlumnos.Negocio;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmConsultas : Form
    {
        private CarreraManager carreraManager;
        private InscriptosCursarManager inscriptosCursarManager;

        public DateTime fecha = DateTime.Now ;
        
        public FrmConsultas()
        {
            carreraManager = new CarreraManager();
            inscriptosCursarManager = new InscriptosCursarManager();
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            #region DropDownStyle
            this.cmbAñoLectivo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCuatrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDivision.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion

            #region ComboBox
            this.cmbCuatrimestre.Items.Add("Primer cuatrimestre");
            this.cmbCuatrimestre.Items.Add("Segundo cuatrimestre");
            this.cmbTurno.Items.Add("M");
            this.cmbTurno.Items.Add("N");
            this.cmbCarrera.DataSource = carreraManager.TraerTodos();
            this.cmbCarrera.DisplayMember = "";
            //LAS MATERIAS Y CARRERAS QUE SE CARGAN EN EL CMB SON UN NUMERO, SON INT. 
            #endregion

            #region SeleccionadosPorDefecto
            this.cmbTurno.SelectedIndex = 0;
            this.cmbCuatrimestre.SelectedIndex = 0;
            this.cmbAñoLectivo.SelectedIndex = 0;
            #endregion

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idTurno;
            int aprobados = 0;
            int desaprobados = 0;
            int ausentes = 0;

            if (this.cmbAñoLectivo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un año.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(this.cmbAñoLectivo.SelectedItem.ToString()) != fecha.Year)
                {
                    MessageBox.Show("El año lectivo ingresado no es el actual, verificar datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TurnoCursar consulta = new TurnoCursar();
                    consulta.AnioLectivo = int.Parse(this.cmbAñoLectivo.SelectedText);
                    consulta.Cuatrimestre = int.Parse(this.cmbCuatrimestre.SelectedText);
                    consulta.Turno = this.cmbTurno.SelectedText;
                    consulta.IdCarrera = int.Parse(this.cmbCarrera.SelectedText); //LA CARRERA ES UN NUMERO
                    consulta.IdMateria = int.Parse(this.cmbMateria.SelectedText); //LA MATERIA ES UN NUMERO
                    consulta.Division = this.cmbDivision.SelectedText;

                    idTurno = inscriptosCursarManager.TraerIdTurno(this.cmbTurno.SelectedText);
                    foreach (InscriptosCursar item in inscriptosCursarManager.TraerPorIdTurnoCursar(idTurno))
                    {
                        if (item.NotaPrimParcial < 4 || item.NotaSegParcial < 4 || item.Rec1 < 4 || item.Rec2 < 4 || item.Rec3 < 4)
                            desaprobados++;
                        else if (item.NotaPrimParcial == 0 || item.NotaSegParcial == 0 || item.Rec1 == 0 || item.Rec2 == 0 || item.Rec3 == 0)
                            ausentes++;
                        else
                            aprobados++;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).Items.Clear();
                }
            }
        }
    }
}
