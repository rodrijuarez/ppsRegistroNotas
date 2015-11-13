using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Datos;

namespace UTN.SistemaAlumnos.UI
{
    public partial class ConsultarDatosAcademicos : Form
    {
        public ConsultarDatosAcademicos()
        {
            InitializeComponent();
            this.CargarComboCriterio();
        }

        private void CargarDgv()
        {
            
            if (cboCriterio.SelectedIndex == 0)
                dgvTablaAlumnos.DataSource = DatosAlumno.TraerTodosPorApellido(txtIngreso.Text);

            else
                dgvTablaAlumnos.DataSource = DatosAlumno.TraerTodosPorLegajo(txtIngreso.Text);

        }
        private void CargarComboCriterio()
        {
            cboCriterio.Items.Add("Por Apellido");
            cboCriterio.Items.Add("Por Legajo");
            cboCriterio.SelectedIndex = 0;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }
    }
}
