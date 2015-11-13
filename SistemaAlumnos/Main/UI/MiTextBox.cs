using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTN.SistemaAlumnos.UI
{
    public enum Estado { 
        soloNumeros,soloLetras
    }
    public class MiTextBox:TextBox
    {
        public Estado Estado
        {
            get;
            set;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (Estado) 
            {
                case Estado.soloNumeros:
                    if (((Keys)e.KeyChar < Keys.D0 || (Keys)e.KeyChar > Keys.D9) && (Keys)e.KeyChar != Keys.Back)
                        e.Handled = true;
                    break;
                case Estado.soloLetras:
                    if (!char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                        e.Handled = true;
                    break;
            }
            base.OnKeyPress(e);
        }
    }
}
