using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using UTN.SistemaAlumnos;

namespace UTN.SistemaAlumnos.UI
{
    public partial class ConsultaActasExamen : Form
    {
        DataTable miDt = new DataTable("Actas");

        public ConsultaActasExamen()
        {
            InitializeComponent();
        }

        private void ConsultaActasExamen_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 8;

            this.dataGridView1.Columns[0].Name = "Nro. de Tomo";
            this.dataGridView1.Columns[1].Name = "Nro. de Folio";
            this.dataGridView1.Columns[2].Name = "Fecha";
            this.dataGridView1.Columns[3].Name = "Carrera";
            this.dataGridView1.Columns[4].Name = "Materia";
            this.dataGridView1.Columns[5].Name = "Aprobados";
            this.dataGridView1.Columns[6].Name = "Ausentes";
            this.dataGridView1.Columns[7].Name = "Desaprobados";

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            
        }

        private void actaDeExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnActa MiFrm = new frmUnActa();

            if (MiFrm.ShowDialog() == DialogResult.OK)
            {
                this.dataGridView1.Rows.Clear();

                this.dataGridView1.Rows.Add(new object[] { 
                    MiFrm.MiActita.IdTomo,
                    MiFrm.MiActita.IdFolio,
                    MiFrm.MiActita.Fecha,
                    MiFrm.MiActita.IdCarrera,
                    MiFrm.MiActita.IdMateria,
                    MiFrm.MiActita.Aprobados,
                    MiFrm.MiActita.Ausentes,
                    MiFrm.MiActita.Desaprobados
                });
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
    }
}
