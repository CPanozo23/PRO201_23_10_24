using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_23_10_24
{
    public abstract class Persona //CLASE ABSTRACTA
    { //versión clásica
        //atributos
        private String apellidos;
        private String nombres;
        private String documento;
        private String tipo;
        //métodos (get, set y otros)

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public String Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
