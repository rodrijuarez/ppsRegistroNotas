using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmListadoAsistenciasTotal : Form
    {
        public FrmListadoAsistenciasTotal()
        {
            InitializeComponent();
        }

        private void FrmListadoAsistenciasTotal_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            BindingSource ListadoBindingSource = new BindingSource(this.components);

            ListadoBindingSource.DataSource = FrmListadoDeAsistencias.listado;
            reportDataSource.Name = "ObjListado";
            reportDataSource.Value = ListadoBindingSource;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
