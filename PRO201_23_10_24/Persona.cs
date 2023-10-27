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
        //EJEMPLO:
        //SI NO ME INTERESA LLAMAR POR SEPARADO A NOMBRES Y APELLIDOS,NO NECESITO LOS GET
        //PODRÍA CREAR UNA FUNCIÓN APARTE LLAMADA NOMBRE_COMPLETO
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

        //public String NombreCompleto
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

        public void IniciarSesion()
        {
            Console.WriteLine("Iniciando sesión por " + Nombres + " " + Apellidos);
        }
    }
}
