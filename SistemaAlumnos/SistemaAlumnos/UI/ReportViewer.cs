//using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class ReportViewer : Form
    {
        public ReportViewer(String PathReporte, Object ListaEntidades, String WindowTitle = "Reporte")
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(WindowTitle))
                this.Text = WindowTitle;

            /*this.rptViewer.Reset();
            this.rptViewer.LocalReport.ReportPath = PathReporte;
            this.rptViewer.LocalReport.EnableExternalImages = true;
            this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("OrigenDatos", ListaEntidades));
            this.rptViewer.RefreshReport();*/
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            //this.rptViewer.RefreshReport();
        }
    }
}