using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class FrmMateriaDivision : Form
    {
        List<ComboBoxMateriaDivision> unComboBoxMateriaDivision = new List<ComboBoxMateriaDivision>();

        public FrmMateriaDivision()
        {
            InitializeComponent();
        }


        private void FrmMateriaDivision_Load(object sender, EventArgs e)
        {

            int anteriorIdMateria = -1;
            ComboBoxMateriaDivision item = new ComboBoxMateriaDivision();
            Comparison<MateriaDivision> miComparador;

            miComparador = new Comparison<MateriaDivision>(OrdenarMateriaDivision);
            FrmTurno.listaMateriaDivision.Sort(miComparador);
            cbo_materia.DisplayMember = "Text";
            cbo_materia.ValueMember = "Value";

            unComboBoxMateriaDivision.Clear();
            foreach (MateriaDivision unaMateria in FrmTurno.listaMateriaDivision)
            {
                if (unaMateria.idMateria != anteriorIdMateria)
                {
                    anteriorIdMateria = unaMateria.idMateria;
                    item = new ComboBoxMateriaDivision();
                    item.Text = unaMateria.descripcion;
                    item.Value = unaMateria.idMateria;
                    unComboBoxMateriaDivision.Add(item);
                }
            }
            cbo_materia.DataSource = unComboBoxMateriaDivision;
            cbo_materia.SelectedIndex = 0;
        }

        private void cbo_materia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbo_division.Items.Clear();
            foreach (MateriaDivision unaMateria in FrmTurno.listaMateriaDivision)
            {
                if (unaMateria.idMateria.ToString() == (cbo_materia.Items[cbo_materia.SelectedIndex] as ComboBoxMateriaDivision).Value.ToString())
                {
                    cbo_division.Items.Add(unaMateria.division);
                }
            }
            cbo_division.SelectedIndex = 0;
        }


        private void btn_mostrar_listado_Click(object sender, EventArgs e)
        {

            if (cbo_division.SelectedIndex >= 0)
            {
                //FrmListadoDeAsistencias.listado = DatosListado.TraerxTurnoMateriaDivision(FrmTurno.turnoElegido, Int32.Parse((cbo_materia.Items[cbo_materia.SelectedIndex] as ComboBoxMateriaDivision).Value.ToString()), cbo_division.SelectedText);
                //Llamada a ReportingServices
                FrmListadoDeAsistencias.listado.Clear();
                ListadoAsistencias a = new ListadoAsistencias();
                ListadoAsistencias b = new ListadoAsistencias();
                a.descripcionCarrera = "FILTRO CarreraA";
                a.descripcionMateria = "FILTRO MateriaA";
                a.apellidoProfesor = "FILTRO ProfesorA";
                a.nombreProfesor = "FILTRO ProfesorA";
                a.apellidoAlumno = "FILTRO AlumnoA";
                a.nombreAlumno = "FILTRO AlumnoA";
                FrmListadoDeAsistencias.listado.Add(a);


                b.descripcionCarrera = "FILTRO CarreraB";
                b.descripcionMateria = "FILTRO MateriaB";
                b.apellidoProfesor = "FILTRO ProfesorB";
                b.nombreProfesor = "FILTRO ProfesorB";
                b.apellidoAlumno = "FILTRO AlumnoB";
                b.nombreAlumno = "FILTRO AlumnoB";
                FrmListadoDeAsistencias.listado.Add(b);

                FrmListadoAsistenciasTotal frm = new FrmListadoAsistenciasTotal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione Materia y División para poder mostrar el listado", "Atención", MessageBoxButtons.OK);
            }
        }

        //Comparison:
        public static int OrdenarMateriaDivision(MateriaDivision a, MateriaDivision b)
        {
            int xdiff = a.descripcion.CompareTo(b.descripcion);
            if (xdiff != 0) return xdiff;
            else return a.division.CompareTo(b.division);
        }


    }
}
