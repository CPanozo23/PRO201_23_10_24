using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_23_10_24
{
    class Venta
    {
        //visibilidad tipo nombre
        private int idVenta;
        private Cliente cliente;
        private List<Producto> productosVenta;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public List<Producto> ProductosVenta
        {
            get { return productosVenta; }
            set { productosVenta = value; }
        }

    }
}
