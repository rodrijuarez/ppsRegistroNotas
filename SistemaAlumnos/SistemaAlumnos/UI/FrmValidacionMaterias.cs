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
    public partial class FrmValidacionMaterias : Form
    {



        public FrmValidacionMaterias()
        {
            InitializeComponent();
        }

        private void FrmValidacionMaterias_Load(object sender, EventArgs e)
        {

        }
        public void ValidarTurno(string turno)
        {

        }
        public void ValidarDiaDictado(string turno)
        {

        }
        public void ValidarDivision(string turno)
        {

        }
        public void ValidarDuracion(string turno)
        {

        }
        private void txtTurnos_TextChanged(object sender, EventArgs e)
        {
            ValidarTurno(txtTurnos.Text);
        }

        private void txtDiaDictado_TextChanged(object sender, EventArgs e)
        {
            ValidarDiaDictado(txtDiaDictado.Text);
        }

        private void txtDivisión_TextChanged(object sender, EventArgs e)
        {
            ValidarDivision(txtDivisión.Text);
        }

        private void txtDuración_TextChanged(object sender, EventArgs e)
        {
            ValidarDuracion(txtDuración.Text);
        }


    }
}
