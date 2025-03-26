using Sasia1Colombara2.Models;

namespace Sasia1Colombara2 {

    public class program
    {
     
       static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();


            Alumno alumno1 = new Alumno();
            alumno1.usuario = 1;
            alumno1.apellido = "Sasia";
            alumno1.nombre = "Juan";
            alumno1.celular = "3425155063";

            Alumno alumno2 = new Alumno();
            alumno2.usuario = 2;
            alumno2.apellido = "Colombara";
            alumno2.nombre = "Francisco";
            alumno2.celular = "3425486548";

            Alumno alumno3 = new Alumno();
            alumno3.usuario = 3;
            alumno3.apellido = "Re";
            alumno3.nombre = "Florencia";
            alumno3.celular = "3424666618";

            Alumno alumno4 = new Alumno();
            alumno4.usuario = 4;
            alumno4.apellido = "Cintia";
            alumno4.nombre = "Cintia";
            alumno4.celular = "1164430699";

            listaAlumnos.Add(alumno1);
            listaAlumnos.Add(alumno2);
            listaAlumnos.Add(alumno3);
            listaAlumnos.Add(alumno4);


            foreach (var alumno in listaAlumnos)

            {
               Console.WriteLine("Los datos del alumno son: ");
                Console.WriteLine("Usuario nro: " + alumno.usuario);
               Console.WriteLine("Apellido: " + alumno.apellido);
               Console.WriteLine("Nombre: " + alumno.nombre);
               Console.WriteLine("Celular: " + alumno.celular);
               Console.WriteLine("--------------------------------");
            }


        }

    }
}