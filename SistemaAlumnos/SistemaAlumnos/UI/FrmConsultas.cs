using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmConsultas : Form
    {

        public DateTime fecha = DateTime.Now ;
        
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            this.cmbAñoLectivo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCuatrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDivision.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
