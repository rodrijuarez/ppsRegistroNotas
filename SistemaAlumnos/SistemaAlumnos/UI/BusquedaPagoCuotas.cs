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
    public partial class frmBusquedaPagoCuotas : Form
    {
        public frmBusquedaPagoCuotas()
        {
            InitializeComponent();
        }

        private void frmBusquedaPagoCuotas_Load(object sender, EventArgs e)
        {
            /*
            DataTable tablaPrueba = new DataTable("Prueba");
            tablaPrueba.Columns.Add("Id", typeof(int));
            tablaPrueba.Columns.Add("Nombre",typeof(string));
            tablaPrueba.Columns.Add("Apellido", typeof(string));
            tablaPrueba.PrimaryKey = new DataColumn[] { tablaPrueba.Columns["Id"] };
            tablaPrueba.Columns["Id"].AutoIncrement = true;
            tablaPrueba.Columns["Id"].AutoIncrementSeed= 1;
            tablaPrueba.Columns["Id"].AutoIncrementStep = 1;

            tablaPrueba.Rows.Add(new object[]{null,"Mariano","Martinez"});
            tablaPrueba.Rows.Add(new object[]{null,"Pablo", "Perez" });*/

            
           // this.dvgBusqueda.DataSource = tablaPrueba;
            //this.dvgBusqueda.Columns[0].Visible = false;
            this.btnAceptarBusqueda.Anchor = AnchorStyles.Top;
            this.dvgBusqueda.Anchor = AnchorStyles.Top;

                   




    }

}
}
