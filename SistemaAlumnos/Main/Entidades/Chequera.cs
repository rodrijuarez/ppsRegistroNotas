using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class Chequera
    {
        public int idChequera { get; set; }
        public int AnioLectivo { get; set; }
        public int Cuatrimestre { get; set; }
        public decimal valorCuota { get; set; }
        public string idLegajo { get; set; }
        public DateTime FechaPago1 { get; set; }
        public Decimal ImportePago1 { get; set; }
        public DateTime FechaPago2 { get; set; }
        public Decimal ImportePago2 { get; set; }
        public DateTime FechaPago3 { get; set; }
        public Decimal  ImportePago3 { get; set; }
        public DateTime FechaPago4 { get; set; }
        public Decimal  ImportePago4 { get; set; }
        public DateTime FechaPago5 { get; set; }
        public Decimal  ImportePago5 { get; set; }
        public DateTime FechaPagoMatricula { get; set; }
        public string Estado { get; set; }
            


    }
}
