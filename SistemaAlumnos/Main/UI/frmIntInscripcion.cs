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
    public partial class frmIntInscripcion : Form
    {
        public frmIntInscripcion()
        {
            InitializeComponent();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmIntInscripcion_Load(object sender, EventArgs e)
        {
            frmIntInscripcion frm = new frmIntInscripcion();
            frm.WindowState = FormWindowState.Normal;
            
        }
    }
}
