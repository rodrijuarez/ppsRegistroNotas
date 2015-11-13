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
    public partial class RegistrarTurnoExamen : Form
    {
        public RegistrarTurnoExamen()
        {
            InitializeComponent();
        }        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (object sen in gbxContenedor.Controls)
            {
                if (sen is ComboBox)
                {
                    ((ComboBox)sen).Text = "";
                }
                if (sen is RadioButton)
                {
                    ((RadioButton)sen).Checked = false;
                }
                if (sen is DateTimePicker)
                {
                    ((DateTimePicker)sen).Text = "";
                }
            }
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RegistrarTurnoExamen_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }

        public void CargarCarreras()
        { 
            List<Carrera> lista = DatosCarreras.TraerTodas();
            foreach(var aux in lista)
            {
                cmbCarrera.Items.Add(aux);
            }
        }

    }
}
