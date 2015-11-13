using System;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Negocio;
using UTN.SistemaAlumnos.Entidades;
using System.Collections.Generic;
using System.Drawing;

namespace UTN.SistemaAlumnos.UI
{
    public partial class IntRegisNotas : Form
    {
        private CarreraManager carreraManager;

        private MateriaManager materiaManager;

        private TurnoCursarManager turnoCursarManager;

        private InscriptosCursarManager inscriptosCursarManager;

        private List<Object> listaDeObjectos;

        TurnoCursar turnoCursar;

        public IntRegisNotas()
        {
            InitializeComponent();
            InicializarManagers();
            llenarComboboxCarreras();
            InicializarGrilla();            
        }

        private void InicializarManagers()
        {
            carreraManager = new CarreraManager();
            materiaManager = new MateriaManager();
            turnoCursarManager = new TurnoCursarManager();
            inscriptosCursarManager = new InscriptosCursarManager();
        }

        private void CambioComboboxCarrera(object sender, EventArgs e)
        {
            ActualizarComboboxMaterias();
        }

        private void CambioComboboxMateria(object sender, EventArgs e)
        {
            ActualizarComboboxTurno();
        }

        private void CambioComboboxTurno(object sender, EventArgs e)
        {
            ActualizarComboboxDivision();
        }

        private void ActualizarComboboxMaterias()
        {
            cmbMateria.Items.Clear();
            materiaManager.TraerMateriasPorIdCarrera(((Carrera)cmbCarrera.SelectedItem).Id).ForEach(
                    materia => cmbMateria.Items.Add(materia)
            );
        }

        private void ActualizarComboboxTurno()
        {
            cmbTurnos.Items.Clear();
            turnoCursarManager.TraerTurnoCursarPorIdMateria(((Materia)cmbMateria.SelectedItem).IdMateria).ForEach(
                    turnoCursar => cmbTurnos.Items.Add(turnoCursar)
            );
        }
        private void ActualizarComboboxDivision()
        {
            cmbDivision.Items.Clear();
            turnoCursarManager.TraerTurnoCursarPorIdMateriaYTurno(((Materia)cmbMateria.SelectedItem).IdMateria, ((TurnoCursar)cmbTurnos.SelectedItem).Turno).ForEach(
                    turnoCursar => cmbDivision.Items.Add(turnoCursar.Division)
            );

        }

        private void llenarComboboxCarreras()
        {
            carreraManager.TraerTodos().ForEach(
                carrera => this.cmbCarrera.Items.Add(carrera)
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new IntNotaAlumno())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Ok");
                }
                else
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void IntRegisNotas_Load(object sender, EventArgs e)
        {


        }

        private void buscarAlumnos(object sender, MouseEventArgs e)
        {
            BuscarAlumnos();
        }

        private void BuscarAlumnos()
        {
            if(txtLegajo.Text != ""){
                this.filtrarConLegajo();
            }else{
                this.filtrar();
            }


        }
            
        private void filtrar()
        {
            turnoCursar = turnoCursarManager.TraerTurnoCursarFiltrado(((Materia)cmbMateria.SelectedItem).IdMateria, ((TurnoCursar)cmbTurnos.SelectedItem).Turno, int.Parse(cmbDivision.SelectedItem.ToString()));
            List<InscriptosCursar> inscriptosCursar = inscriptosCursarManager.TraerPorIdTurnoCursar(turnoCursar.idTurnosCursar);
            listaDeObjectos = new List<Object>();
            inscriptosCursar.ForEach(
                    inscriptoCursar => listaDeObjectos.Add(new
                    {
                        Legajo = inscriptoCursar.idLegajo,
                        Apellido = inscriptoCursar.alumno.Apellido,
                        Nombre = inscriptoCursar.alumno.Nombre,
                        NotaPrimParcial = inscriptoCursar.NotaPrimParcial,
                        NotaSegParcial = inscriptoCursar.NotaSegParcial,
                        PrimerRecTipo = inscriptoCursar.PrimerRecTipo,
                        Rec1 = inscriptoCursar.Rec1,
                        SegRecTipo = inscriptoCursar.SegRecTipo,
                        Rec2 = inscriptoCursar.Rec2,
                        TerRecTipo = inscriptoCursar.TerRecTipo,
                        Rec3 = inscriptoCursar.Rec3
                    })
            );
            
            dgvAlumnos.DataSource = listaDeObjectos;
        }

        private void filtrarConLegajo()
        {
            turnoCursar = turnoCursarManager.TraerTurnoCursarFiltrado(((Materia)cmbMateria.SelectedItem).IdMateria, ((TurnoCursar)cmbTurnos.SelectedItem).Turno, int.Parse(cmbDivision.SelectedItem.ToString()));
            List<InscriptosCursar> inscriptosCursar = inscriptosCursarManager.TraerPorIdTurnoCursarYLegajo(turnoCursar.idTurnosCursar, int.Parse(txtLegajo.Text));
            listaDeObjectos = new List<Object>();
            inscriptosCursar.ForEach(
                    inscriptoCursar => listaDeObjectos.Add(new
                    {
                        Legajo = inscriptoCursar.idLegajo,
                        Apellido = inscriptoCursar.alumno.Apellido,
                        Nombre = inscriptoCursar.alumno.Nombre,
                        NotaPrimParcial = inscriptoCursar.NotaPrimParcial,
                        NotaSegParcial = inscriptoCursar.NotaSegParcial,
                        PrimerRecTipo = inscriptoCursar.PrimerRecTipo,
                        Rec1 = inscriptoCursar.Rec1,
                        SegRecTipo = inscriptoCursar.SegRecTipo,
                        Rec2 = inscriptoCursar.Rec2,
                        TerRecTipo = inscriptoCursar.TerRecTipo,
                        Rec3 = inscriptoCursar.Rec3
                    })
            );
            dgvAlumnos.DataSource = listaDeObjectos;
        }

        private void ValidarNumerico(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == (Char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void RelizarBusqueda(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                BuscarAlumnos();
            }
        }

        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            int indice = this.dgvAlumnos.CurrentRow.Index;
            
            MessageBox.Show(indice.ToString());

            IntNotaAlumno formNotaAlumno = new IntNotaAlumno();
            formNotaAlumno.ShowDialog();
            //formNotaAlumno = new IntNotaAlumno (dgvAlumnos.CurrentRow.Cells[0] + dgvAlumnos.CurrentRow.Cells[1], 
 
            //this.dgvAlumnos.CurrentRow.Index
        }

        private void InicializarGrilla()
        {            
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvAlumnos.EnableHeadersVisualStyles = true;
            // seteo el formato del encabezado
            dgvAlumnos.RowHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.ColumnHeadersVisible = true;

            // doy formato a las filas
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.RowsDefaultCellStyle.BackColor = Color.Gray;
            dgvAlumnos.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvAlumnos.RowsDefaultCellStyle.SelectionBackColor = Color.LightGreen;
            dgvAlumnos.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AllowUserToResizeColumns = false;
            dgvAlumnos.AllowUserToResizeRows = false;
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlumnos.BackgroundColor = Color.LightSlateGray;
            dgvAlumnos.BorderStyle = BorderStyle.Fixed3D;
            dgvAlumnos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAlumnos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvAlumnos.DefaultCellStyle.BackColor = Color.Black;
            dgvAlumnos.EnableHeadersVisualStyles = true;
            dgvAlumnos.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvAlumnos.RowHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
            dgvAlumnos.RowHeadersDefaultCellStyle.ForeColor = Color.Green;

        }
    }
}
