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
    public partial class RegistrarPagoCuota : Form
    {
        Entidades.Alumno alu;
        public RegistrarPagoCuota()
        {
            
            InitializeComponent();
            this.FormClosing += this.Salir;
            //COMETARIO DE PRUEBA
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BusquedaInteligente();
        }

        private void RegistrarPagoCuota_Load(object sender, EventArgs e)
        {
            this.grpIngreso.Anchor = AnchorStyles.Top;
            this.grpBusqueda.Anchor = AnchorStyles.Top;
            this.grpDatos.Anchor = AnchorStyles.Top;
            this.btnAceptar.Anchor = AnchorStyles.Top;
            this.btnCancelar.Anchor = AnchorStyles.Top;
        }

        private void BusquedaInteligente() {
            
            if (Negocio.MetodosChequera.EsNumero(this.txtLegajoApellido.Text))
            {
                if(this.txtLegajoApellido.Text.Length==10)
                alu= Datos.datosBusquedaPagoCuotas.TraeALumnoLegajo(this.txtLegajoApellido.Text);
                else
                    MessageBox.Show("La cantidad de digitos no es la establecida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               frmBusquedaPagoCuotas frm =new frmBusquedaPagoCuotas(Datos.datosBusquedaPagoCuotas.TraerALumnoApellido(this.txtLegajoApellido.Text));
               if (frm.ShowDialog() == DialogResult.OK) {
                   alu = frm.UnAlumno;
               }
            
            }

            if (!object.Equals(alu,null))
            {
                Entidades.Chequera unachequera = Datos.datosBusquedaPagoCuotas.TraerChequera(this.alu.IdLegajo.ToString());
                this.txtCuota1.Text = unachequera.ImportePago1.ToString();
                this.dateTimePicker1.Value = (DateTime)unachequera.FechaPago1;
                this.txtCuota2.Text = unachequera.ImportePago2.ToString();
                this.dateTimePicker2.Value = (DateTime)unachequera.FechaPago2;
                this.txtCuota3.Text = unachequera.ImportePago3.ToString();
                this.dateTimePicker3.Value = (DateTime)unachequera.FechaPago3;
                this.txtCuota4.Text = unachequera.ImportePago4.ToString();
                this.dateTimePicker4.Value = (DateTime)unachequera.FechaPago4;
                this.txtCuota5.Text = unachequera.ImportePago5.ToString();
                this.dateTimePicker5.Value = (DateTime)unachequera.FechaPago5;

                this.txtLegajo.Text = alu.IdLegajo.ToString();
                this.txtNombreMostrar.Text = alu.Nombre;
                this.txtApellidoMostrar.Text = alu.Apellido;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtLegajoApellido.Text = "";
        }

        private void LimpiarControladores() {
            foreach (Control item in this.grpIngreso.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            foreach (Control item in this.grpDatos.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).ResetText();
                }
            }
            
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            this.LimpiarControladores();
          
        }

        private void Salir(object sender,FormClosingEventArgs e) {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.RegistroDatos();
        }

        private void RegistroDatos() {
            Entidades.Alumno unAlumno = this.alu;

            Entidades.Chequera unaChequera = new Entidades.Chequera();

            unaChequera.AnioLectivo = int.Parse(this.txtAño.Text);
            unaChequera.Cuatrimestre = int.Parse(this.txtCuatrimestre.Text);
            unaChequera.valorCuota = decimal.Parse(this.txtCuota.Text);
            unaChequera.FechaPago1 = this.dateTimePicker1.Value;
            unaChequera.ImportePago1 = decimal.Parse(this.txtCuota1.Text);
            unaChequera.FechaPago2 = this.dateTimePicker2.Value;
            unaChequera.ImportePago2 = decimal.Parse(this.txtCuota2.Text);
            unaChequera.FechaPago3 = this.dateTimePicker3.Value;
            unaChequera.ImportePago3 = decimal.Parse(this.txtCuota3.Text);
            unaChequera.FechaPago4 = this.dateTimePicker4.Value;
            unaChequera.ImportePago4 = decimal.Parse(this.txtCuota4.Text);
            unaChequera.FechaPago5 = this.dateTimePicker5.Value;
            unaChequera.ImportePago5 = decimal.Parse(this.txtCuota5.Text);
            unaChequera.idLegajo = unAlumno.IdAlumno.ToString();
            


            Datos.datosBusquedaPagoCuotas.HacerPago(unaChequera, unAlumno);
        }
      
    }
}
