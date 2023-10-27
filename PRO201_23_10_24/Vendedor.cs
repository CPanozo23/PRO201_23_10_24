using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO201_23_10_24
{
    public class Vendedor : Persona
    {
        private string tipoContrato;
        private int sueldo;

        public String TipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value; }
        }

        public int Sueldo {
            get { return sueldo; }
            set { sueldo = value; }
        }

    }

}