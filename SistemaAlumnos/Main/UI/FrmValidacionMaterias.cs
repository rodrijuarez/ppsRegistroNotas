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
    public partial class FrmValidacionMaterias : Form
    {

        private void FrmValidacionMaterias_Load(object sender, EventArgs e)
        {

        }

        public void ValidarTurno(char turno)
        {
            if (turno == 'M' || turno == 'N')
            {
                MessageBox.Show("Turno válido");
            }
            else
                MessageBox.Show("ERROR!! Vuelva a intentarlo");
            
        }

        public void ValidarDiaDictado(char dia)
        {
            if (dia == 'L' || dia == 'M' || dia == 'J' || dia == 'V' || dia == 'S')
            {
                MessageBox.Show("Dia de dictado existente");
            }
            else
                MessageBox.Show("ERROR!! No existe ese dia");
        }

        public void ValidarDuracion(char duracion)
        {
            if (duracion == 'C')
            {
                MessageBox.Show("Duración Completa");
            }
            else if (duracion == 'M')
            {
                MessageBox.Show("Duración Media");
            }
            else
                MessageBox.Show("ERROR!! Vuelva a intentarlo");
        }

        private void txtTurnos_keypress(object sender, KeyPressEventArgs e) 
        {
            ValidarTurno(e.KeyChar);
        }
        private void txtDiaDictado_keypress(object sender, KeyPressEventArgs e)
        {
            ValidarDiaDictado(e.KeyChar);
        }
        private void txtDuracion_keypress(object sender, KeyPressEventArgs e)
        {
            ValidarDuracion(e.KeyChar);
        }

    }
}
