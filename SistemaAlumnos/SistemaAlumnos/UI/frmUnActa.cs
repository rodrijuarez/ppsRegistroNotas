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
    public partial class frmUnActa : Form
    {
        public Entidades.Actas MiActita = new Entidades.Actas();

        public frmUnActa()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtFolio.Text == "" || this.txtFolio.Text == "")
            {
                MessageBox.Show("DEBE INFORMAR TOMO Y FOLIO");
            }
            else 
            {
                MiActita = Datos.DatosActas.TraerPorFolioYTomo(int.Parse(this.txtFolio.Text), int.Parse(this.txtFolio.Text));

                if (MiActita.Inscriptos == 0)
                {
                    MessageBox.Show("TOMO Y FOLIO INEXISTENTE");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
