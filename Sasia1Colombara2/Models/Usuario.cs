using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sasia1Colombara2.Models
{
    internal class Usuario
    {
        //Declaro las variables con sus metodos get y set
        public int usuario { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string celular { get; set; }

        /*
         Creo un metodo para pedir al usuario que inicalice las variables 
         con valores obtenidos por teclado
        */

        public void IngresarUsuario() {

            Console.Write("Usuario: ");

            usuario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Celular: ");
            celular = Console.ReadLine();

            Console.WriteLine("--------------------------------");
        }

        //Creo un metodo para imprimir las variables ingresadas por el suario
        public void MostrarDatosUsuario() {

            Console.WriteLine("La persona: " + apellido
                + ", " + nombre
                + " tiene el usuiario: " + usuario
                + " y el celular: " + celular);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");

         

        }
    }
}
