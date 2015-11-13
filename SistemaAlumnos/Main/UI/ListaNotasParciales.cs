using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class ListaNotasParciales : Form
    {
        public ListaNotasParciales(string path, List<AsientoParcial> listaEntidades, string title="")
        {
            InitializeComponent();

            this.reportViewer.Reset();
            this.reportViewer.LocalReport.ReportPath = path;
            this.reportViewer.LocalReport.EnableExternalImages = true;
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listaEntidades));
            this.reportViewer.RefreshReport();
        }

        private void ListaNotasParciales_Load(object sender, EventArgs e)
        {
            //using (var form = new ReportViewer(@"C:\Users\alumno.LAB5PC03\Desktop\tp\SistemaAlumnos\Main\UI\Report1.rdlc",Datos.DatosParciales.TraerTodas(),"Reporte"))
            //{
            //    form.ShowDialog();
            //}
            //this.reportViewer1.RefreshReport();*/
           // this.reportViewer1.RefreshReport();
            this.reportViewer.RefreshReport();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
