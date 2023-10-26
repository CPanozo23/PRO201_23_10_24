using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_23_10_24
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Holi"); //Console.wrl
            Console.WriteLine(Operaciones.Suma(1,2));
            Console.WriteLine("------------------------");
            //Crear objeto tipo Persona
            //NOMBRE_CLASE nombre_objeto = new NOMBRE_CLASE
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

            Cliente cli1 = new Cliente
            {
                Apellidos = "Díaz López", //utiliza set
                Nombres = "Carlos Andrés",
                Documento = "555-4",
                Tipo = "Tipo Persona Y",
                Categoria = "VIP",
                Codigo = "V001"
            };

            //Mostrar datos
            //Console.WriteLine(persona1.Nombres); //utiliza get
            //Console.WriteLine(persona2.Nombres);
            Console.WriteLine(cli1.Nombres);

            Console.ReadKey();
        }
    }
}
