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
    public partial class RegistrarPagoCuota : Form
    {
        public RegistrarPagoCuota()
        {
            InitializeComponent();
            //COMETARIO DE PRUEBA
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPagoCuotas frm = new frmBusquedaPagoCuotas();
            frm.ShowDialog();
        }

        private void RegistrarPagoCuota_Load(object sender, EventArgs e)
        {
            this.grpIngreso.Anchor = AnchorStyles.Top;
            this.grpBusqueda.Anchor = AnchorStyles.Top;
            this.grpDatos.Anchor = AnchorStyles.Top;
            this.btnAceptar.Anchor = AnchorStyles.Top;
            this.btnCancelar.Anchor = AnchorStyles.Top;
        }
    }
}
