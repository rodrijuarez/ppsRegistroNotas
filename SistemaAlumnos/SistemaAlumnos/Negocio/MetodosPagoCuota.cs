using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pps
{
    public class MetodosChequera
    {
        public static bool ValidarCuatrimestre(string cuatrimestre)
        {
            if (int.Parse(cuatrimestre) <= 2 && int.Parse(cuatrimestre) >= 1)
            {
                return true;
            }
            return false;
        }

        public static bool EsNumero(string cantidad)
        {
            int resultado_;
            return int.TryParse(cantidad, out resultado_);
        }

        public static bool ValidarFecha(string fecha)
        {
            if (EsNumero(fecha))
            {
                if (DateTime.Now.Year.CompareTo(int.Parse(fecha)) >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidarDiaPago(DateTime dia)
        {
            if (DateTime.Now.ToShortDateString().CompareTo(dia.ToShortDateString()) >= 0)
            {
                return true;
            }
            return false;
        }


    }
}

