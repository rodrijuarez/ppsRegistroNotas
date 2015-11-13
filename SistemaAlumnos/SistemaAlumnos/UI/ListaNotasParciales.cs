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
    public partial class ListaNotasParciales : Form
    {
        public ListaNotasParciales()
        {
            InitializeComponent();
        }

        private void ListaNotasParciales_Load(object sender, EventArgs e)
        {
            using (var form = new ReportViewer("",sender,""))
            {
                form.ShowDialog();
            }
            //this.reportViewer1.RefreshReport();*/
        }
    }
}
