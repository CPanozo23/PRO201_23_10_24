using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_23_10_24
{
    class Cliente : Persona //herencia
    {
        //atributos propios
        private String categoria;
        private String codigo;

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        
    }
}
