using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

using UTN.SistemaAlumnos.Entidades;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Negocio;

namespace UTN.SistemaAlumnos.UI
{
    public partial class frmRegistrarTurnosCursada : Form
    {
        private TurnoCursarManager turnoCursarManager;
        private MateriaManager materiaManager;
        private List<Carrera> l_carreras = new List<Carrera>();
        private List<Materia> l_materias = new List<Materia>();
        private List<TurnoCursar> l_turnoscursar = new List<TurnoCursar>();
        private List<int> l_modificados = new List<int>();
        private CarreraManager carreraManager;

        public frmRegistrarTurnosCursada()
        {
            InitializeComponent();
            InicializarManagers();

            carreraManager = new CarreraManager();

            this.l_carreras = carreraManager.TraerTodos();
            CargarCMBCarreras();
            ConfigurarDGVDatosTurnosMateria();
        }

        private void InicializarManagers()
        {
            turnoCursarManager = new TurnoCursarManager();
        }

        private void CargarCMBCarreras()
        {
            foreach (Carrera carr in this.l_carreras)
            {
                this.cmbCarreras.Items.Add(carr.Descripcion);
            }

        }


        private void CargarCMBMaterias()
        {
            this.cmbMaterias.Items.Clear();

            foreach (Materia mate in this.l_materias)
            {
                this.cmbMaterias.Items.Add(mate.Descripcion);
            }
        }


        private void CargarDGVDatosTurnosMateria()
        {
            this.dgvDatosTurnosMateria.Rows.Clear();

            this.l_turnoscursar = turnoCursarManager.TraerTurnoCursarPorIdMateria(this.l_materias[this.cmbMaterias.SelectedIndex].IdMateria);
            foreach (TurnoCursar t in this.l_turnoscursar)
            {
                dgvDatosTurnosMateria.Rows.Add(new object[] { t.idTurnosCursar, t.AnioLectivo, t.Cuatrimestre, t.DiaDictado1, t.DiaDictado2, t.Division, t.Duracion1, t.Duracion2, t.IdProfesor, t.IdMateria, t.IdCarrera, t.Turno });
            }

        }

        private void ConfigurarDGVDatosTurnosMateria()
        {
            Type temp = typeof(TurnoCursar);
            int countM = 0;
            List<string> nombresPropiedades = new List<string>();

            foreach (PropertyInfo propiedad in temp.GetProperties())
            {
                nombresPropiedades.Add(propiedad.Name);
                countM++;
            }

            this.dgvDatosTurnosMateria.ColumnCount = countM;

            this.dgvDatosTurnosMateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosTurnosMateria.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvDatosTurnosMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosTurnosMateria.MultiSelect = false;
            this.dgvDatosTurnosMateria.AllowUserToAddRows = false;

            for (int i = 0; i < nombresPropiedades.Count; i++)
            {
                this.dgvDatosTurnosMateria.Columns[i].Name = nombresPropiedades[i];
            }
        }

        //Metodos de alta y modificacion

        private void Alta()
        {
            TurnoCursar t = new TurnoCursar();
            t.AnioLectivo = 2015;
            t.Cuatrimestre = 4;
            t.DiaDictado1 = "lu";
            t.DiaDictado2 = "ma";
            t.Division = "4a";
            t.Duracion1 = "4";
            t.Duracion2 = "4";
            t.IdCarrera = 1;
            t.IdMateria = 1;
            t.IdProfesor = 5;
            t.Turno = "m";
            //DatosTurnoCursar.Guardar(t);
        }

        private void Modificar()
        {
            TurnoCursar t = new TurnoCursar();
            t.idTurnosCursar = 6;
            t.AnioLectivo = 2016;
            t.Cuatrimestre = 4;
            t.DiaDictado1 = "lu";
            t.DiaDictado2 = "ma";
            t.Division = "4a";
            t.Duracion1 = "4";
            t.Duracion2 = "4";
            t.IdCarrera = 1;
            t.IdMateria = 1;
            t.IdProfesor = 5;
            t.Turno = "m";
            //DatosTurnoCursar.Modificar(t);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTurnos nuevoTurno = new FrmTurnos();
            if (nuevoTurno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.l_turnoscursar.Add(nuevoTurno.Turno);
            }

            Alta();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int tempIndex = 0;

            foreach (TurnoCursar turno in this.l_turnoscursar)
	        {
                tempIndex++;
                if (turno.idTurnosCursar.ToString() == this.dgvDatosTurnosMateria.SelectedCells[0].ToString())
	            {
                    FrmTurnos turnoModificado = new FrmTurnos(turno);

                    if (turnoModificado.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.l_modificados.Add(turno.idTurnosCursar);
                        this.l_turnoscursar.RemoveAt(tempIndex);
                        this.l_turnoscursar.Add(turno);
                        break;
                    }
	            }
	        }
            

            Modificar();
        }

        private void cmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.l_materias = materiaManager.TraerMateriasPorIdCarrera(this.l_carreras[this.cmbCarreras.SelectedIndex].Id);

            this.dgvDatosTurnosMateria.Rows.Clear();
            CargarCMBMaterias();
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDGVDatosTurnosMateria();
        }

        private void frmRegistrarTurnosCursada_FormClosing(object sender, FormClosingEventArgs e)
        {
            int temp = 0;

            foreach (TurnoCursar turno in this.l_turnoscursar)
            {
                if (turno.idTurnosCursar == 0)
                {
                    //DatosTurnoCursar.Guardar(turno);
                }
                else
                {
                    foreach (int id in this.l_modificados)
                    {
                        if ( turno.idTurnosCursar == id)
                        {
                            //DatosTurnoCursar.Modificar(turno);
                            temp = id;
                            break;
                        }
                    }
                }

                if (temp!=0)
                {
                    this.l_modificados.Remove(temp);
                    temp = 0;
                }
            }
        }
    }
}
