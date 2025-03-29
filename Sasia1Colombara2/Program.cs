using Sasia1Colombara2.Models;


namespace Sasia1Colombara2 {

    public class program
    {

        /*1-  Nombres de los integrantes
         * Alumnos:
         * Sasia Juan Ignacio, Dni 37713879
         * Colombara Francisco, Dni 37396363
         * Re Florencia, Dni 38897504
         * Centurion Cintia, Dni  29434601
         */
        static void Main(string[] args)
        {

            Usuario nuevoUsuario = new Usuario();

            /*
             2 - Solicitar por línea de comandos que el usuario ingrese: 
            Usuario
            Apellido 
            Nombre
            Celular
            */

            Console.WriteLine("Ingrese los datos del Usuario: ");

            nuevoUsuario.IngresarUsuario();

            /*
             3- Mostrar por consola los datos ingresados
            */

            Console.WriteLine("Datos del Usuario: ");

            nuevoUsuario.MostrarDatosUsuario();


            //4 - Definir  una variable de cada tipo e imprimirla por pantalla
            Variables variables = new Variables();
            Console.WriteLine("Variables: ");
            variables.MostrarVariables();

            //5 - Mostrar por pantalla el valor mínimo y máximo de cada variable numérica
            Console.WriteLine("Minimo de cada variable: ");
            variables.MostrarMinimo();
            Console.WriteLine("Maximo de cada variable: ");
            variables.MostrarMaximo();



            
        }
           }
           }
            


 
