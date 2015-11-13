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
    public partial class IntCorrelatividadCursar : Form
    {
        private TextBox textBox2;
        List<Entidades.InscriptosRendir> Lista = Datos.DatosInscriptosRendir.TraerTodas();
        public IntCorrelatividadCursar()
        {
            InitializeComponent();
        }

        private void IntCorrelatividadCursar_Load(object sender, EventArgs e)
        {
            foreach (Entidades.InscriptosRendir renglon in Lista)
            {
                textBox1.Text = renglon.IdLegajo.ToString();
            }

        }

        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 230);
            this.textBox2.TabIndex = 2;
            // 
            // IntCorrelatividadCursar
            // 
            this.ClientSize = new System.Drawing.Size(551, 297);
            this.Controls.Add(this.textBox2);
            this.Name = "IntCorrelatividadCursar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
