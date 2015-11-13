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

        private Entidades.Alumno unAlumno;

        public Entidades.Alumno UnAlumno
        {
            get { return unAlumno; }
            set { unAlumno = value; }
        }

        
        public frmBusquedaPagoCuotas()
        {
            InitializeComponent();
        }

        private void frmBusquedaPagoCuotas_Load(object sender, EventArgs e)
        {

            this.btnAceptarBusqueda.Anchor = AnchorStyles.Top;
            this.dvgBusqueda.Anchor = AnchorStyles.Top;

         }
        public frmBusquedaPagoCuotas(List<Entidades.Alumno> alu):this()
        {
            this.dvgBusqueda.SuspendLayout();
            this.dvgBusqueda.Columns[0].DataPropertyName = "IdLegajo";
            this.dvgBusqueda.Columns[1].DataPropertyName = "Nombre";
            this.dvgBusqueda.Columns[2].DataPropertyName = "Apellido";
            //this.dvgBusqueda.DataSource = alu;
            foreach (Entidades.Alumno item in alu)
            {
                this.dvgBusqueda.Rows.Add(item.IdLegajo,item.Nombre,item.Apellido);
            }
            this.dvgBusqueda.ResumeLayout();
        }

        private void btnAceptarBusqueda_Click(object sender, EventArgs e)
        {
            if (this.dvgBusqueda.SelectedRows.Count > 0)
            {
                this.unAlumno = new Entidades.Alumno();
                // MessageBox.Show(this.dvgBusqueda.SelectedRows[0].Cells[0].Value.ToString()); tambien funciona para tomar valores de la row seleccionada
                this.UnAlumno.IdLegajo = this.dvgBusqueda.CurrentRow.Cells[0].Value.ToString();
                this.UnAlumno.Nombre = this.dvgBusqueda.CurrentRow.Cells[1].Value.ToString();
                this.UnAlumno.Apellido = this.dvgBusqueda.CurrentRow.Cells[2].Value.ToString();


                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

    }
}
