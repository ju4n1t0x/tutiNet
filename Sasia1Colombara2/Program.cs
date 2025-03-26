using Sasia1Colombara2.Models;

namespace Sasia1Colombara2 {

    public class program
    {
    /*
         * Alumnos:
         * Sasia Juan Ignacio, Dni 37713879
         * Colombara Francisco, Dni
         * Re Florencia, Dni
         * Cintia, 
         */
       static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();

            Alumno nuevoAlumno = new Alumno();

                Console.WriteLine("Ingrese los datos del Usuario: ");

                Console.Write("Usuario: ");
                nuevoAlumno.usuario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Apellido: ");
                nuevoAlumno.apellido = Console.ReadLine();

                Console.Write("Nombre: ");
                nuevoAlumno.nombre = Console.ReadLine();

                Console.Write("Celular: ");
                nuevoAlumno.celular = Console.ReadLine();

                Console.WriteLine("--------------------------------");

            foreach (var alumno in listaAlumnos)

            Console.WriteLine("La persona: " + nuevoAlumno.apellido
                + ", " + nuevoAlumno.nombre
                + " tiene el usuiario: " + nuevoAlumno.usuario
                + " y el celular: " + nuevoAlumno.celular);


        }

    }
}
            