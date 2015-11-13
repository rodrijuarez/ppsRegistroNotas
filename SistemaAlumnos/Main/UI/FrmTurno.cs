using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmTurno : Form
    {
        static public List<MateriaDivision> listaMateriaDivision = new List<MateriaDivision>();
        static public string turnoElegido;

        public FrmTurno()
        {
            InitializeComponent();
        }


        private void FrmTurno_Load(object sender, EventArgs e)
        {
            listaMateriaDivision.Clear();
            cbo_turno.Items.Add("M");
            cbo_turno.Items.Add("N");
            cbo_turno.SelectedIndex = 0;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            turnoElegido = cbo_turno.SelectedItem.ToString();
            //listaMateriaDivision = DatosMateriaDivision.TraerMateriasDivisionxTurno(turnoElegido);

            MateriaDivision a = new MateriaDivision();
            MateriaDivision b = new MateriaDivision();
            MateriaDivision c = new MateriaDivision();
            MateriaDivision d = new MateriaDivision();
            MateriaDivision f = new MateriaDivision();

            a.idMateria = 2;
            a.descripcion = "Materia 2";
            a.division = "A";
            listaMateriaDivision.Add(a);

            b.idMateria = 3;
            b.descripcion = "A Materia";
            b.division = "A";
            listaMateriaDivision.Add(b);

            c.idMateria = 1;
            c.descripcion = "Materia 1";
            c.division = "A";
            listaMateriaDivision.Add(c);

            d.idMateria = 2;
            d.descripcion = "Materia 2";
            d.division = "C";
            listaMateriaDivision.Add(d);

            f.idMateria = 2;
            f.descripcion = "Materia 2";
            f.division = "B";
            listaMateriaDivision.Add(f);

            /* 
             * A Materia    A   3
             * Materia 1    A   1
             * Materia 2    A   2
             * Materia 2    B   2
             * Materia 2    C   2
              */
            if (listaMateriaDivision.Count > 0)
            {
                FrmMateriaDivision frm = new FrmMateriaDivision();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se encontraron Materias y/o divisiones para el turno seleccionado", "Atención", MessageBoxButtons.OK);
            }
        }
    }
}
