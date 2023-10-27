using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_23_10_24
{
    class Producto
    {
        private int id;
        private String nombre;
        private int precio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //Constructor
        public Producto (int id, string nombre, int precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
