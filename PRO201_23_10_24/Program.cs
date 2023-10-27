using System;
using System.Collections.Generic;

namespace PRO201_23_10_24
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Holi"); //Console.wrl
            Console.WriteLine(Operaciones.Suma(1, 2));
            Console.WriteLine("------------------------");
            //Crear objeto:
            //NOMBRE_CLASE nombre_objeto = new NOMBRE_CLASE

            //Crear objeto tipo Persona // No funciona ya al ser abstracta la clase
            /*Persona persona1 = new Persona
            {
                Apellidos = "Pérez Pereira",
                Nombres = "José María",
                Documento = "1234-5",
                Tipo = "Tipo Persona X"
            };

            Persona persona2 = new Persona
            {
                Apellidos = "Díaz López",
                Nombres = "Claudia Carolina",
                Documento = "555-4",
                Tipo = "Tipo Persona Y"
            };*/

            //Objeto tipo Cliente
            Cliente cli1 = new Cliente
            {
                Apellidos = "Díaz López", //utiliza set
                Nombres = "Carlos Andrés",
                Documento = "555-4",
                Tipo = "Tipo Persona Y",
                Categoria = "VIP",
                Codigo = "V001"
            };

            Cliente cli2 = new Cliente
            {
                Apellidos = "Díaz López", //utiliza set
                Nombres = "Carla Andrea",
                Documento = "558-4",
                Tipo = "Tipo Persona YY",
                Categoria = "VIP",
                Codigo = "V002"
            };

            Vendedor v = new Vendedor
            {
                Nombres = "Ana Anita",
                Apellidos = "Apelido1 Apellido2",
                Sueldo = 590000,
                Documento = "987-4",
                Tipo = "Vendedor PRO",
                TipoContrato = "Indefinido"
            };

            
            //Objeto tipo Producto previo a crear un constructor
            /*Producto prod = new Producto
            {
                Id = 1,
                Nombre = "Plumón Rojo",
                Precio = 123

            };*/

            //LISTA DE PRODUCTOS DE LA EMPRESA
            List<Producto> listadoProductos = new List<Producto>(); //Es una lista vacía
            //agregar objetos a la lista
            //listadoProductos.Add(prod); // Previo a usar el constructor

            //Creando el objeto al agregar a la lista de productos (necesita el constructor)
            listadoProductos.Add(new Producto(2, "Plumón negro", 3245));
            listadoProductos.Add(new Producto(3, "Plumón azul", 3245));
            listadoProductos.Add(new Producto(4, "Plumón violeta", 3245));
            listadoProductos.Add(new Producto(5, "Plumón verde", 3245));

            Venta venta1 = new Venta
            {
                IdVenta = 1,
                Cliente = cli1
                //TAREA1: AGREGAR 2 PRODUCTOS DE LA LISTA PRINCIPAL
            };


            //Mostrar datos
            //Console.WriteLine(persona1.Nombres); //utiliza get
            //Console.WriteLine(persona2.Nombres);
            Console.WriteLine(cli1.Nombres);
            cli1.IniciarSesion();
            cli2.IniciarSesion();
            Console.WriteLine("---------------------------");
            Console.WriteLine("-- VENTA --");
            Console.WriteLine(venta1.IdVenta);//IMPRIMIR ID DE LA VENTA
            Console.WriteLine(venta1.Cliente.Nombres);//MOSTRAR LOS NOMBRES DEL CLIENTE
            //TAREA2: IMPRIMIR LOS PRODUCTOS DE LA VENTA1
            Console.WriteLine("---------------------------");
            Console.ReadKey();
        }
    }
}
