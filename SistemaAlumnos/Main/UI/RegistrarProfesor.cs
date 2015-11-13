using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class RegistrarProfesor : Form
    {
        public RegistrarProfesor()
        {
            InitializeComponent();
        }

        private Profesor p;

        private bool validar_Campos(object obj/*, tipo*/)
        {
            /* Si (obj es del tipo)
             *  retornar true;
             * sino
             *  retornar false;
             */
            return true;
        }

        private bool agregar_Profesor(Profesor p)
        {
            //SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Profesores_INS", conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = p.Apellido;
            //cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = p.Nombre;
            //cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = p.FechaNacimiento;
            //cmd.Parameters.Add("@DomCalle", SqlDbType.VarChar).Value = p.DomCalle;
            //cmd.Parameters.Add("@DomNro", SqlDbType.VarChar).Value = p.DomNro;
            //cmd.Parameters.Add("@DomPiso", SqlDbType.VarChar).Value = p.DomPiso;
            //cmd.Parameters.Add("@DomDepto", SqlDbType.VarChar).Value = p.DomDepto;
            //cmd.Parameters.Add("@DomCodPostal", SqlDbType.VarChar).Value = p.DomCodPostal;
            //cmd.Parameters.Add("@DomProv", SqlDbType.Int).Value = p.DomProv;
            //cmd.Parameters.Add("@DomLocalidad", SqlDbType.VarChar).Value = p.DomLocalidad;
            //cmd.Parameters.Add("@Mail", SqlDbType.VarChar).Value = p.Mail;
            //cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = p.Telefono;
            //cmd.Parameters.Add("@Estadolegajo", SqlDbType.Char).Value = p.Estado;
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read()) /* aca hay algo que no esta bien */
            //{
            //    //conn.Close();
            //    return true;
            //}
            //else
            //{
            //    //conn.Close();
            //    return false;
            //}
            return true;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            
            //if(validar_Campos(Apellido.Text)/*agregar los otros campos a validar*/)
            //{
            //    p = new Profesor();
            //    p.Apellido = Apellido.Text;
            //    /* agregar los otros campos */
            //    this.DialogResult = DialogResult.OK;
            //}
            p = new Profesor();
            p.Apellido = "A";
            p.Nombre = "B";
            p.DomCalle = "";
            p.DomCodPostal = "";
            p.DomDepto = "";
            p.DomLocalidad = "";
            p.DomNro = "";
            p.DomPiso = "";
            p.DomProv = 1;
            p.Estado = 'a';
            p.FechaNacimiento = DateTime.Today;
            p.Mail = "";
            p.Telefono = "";
            this.DialogResult = DialogResult.OK;
            if (this.DialogResult == DialogResult.OK)
            {
                if (agregar_Profesor(this.p))
                    MessageBox.Show("Profesor agregado exitosamente!");
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
