using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sasia1Colombara2.Models
{            /*
             * 4 - Definir  una variable de cada tipo e imprimirla por pantalla
             */
    internal class Variables
    {
        //Defino cada una de las variables
        public bool boleano { get; set; }
        public byte esByte { get; set; }
        public char caracter { get; set; }
        public decimal esDecimal { get; set; }
        public double esDouble { get; set; }
        public float esFloat { get; set; }
        public int esInt { get; set; }
        public long esLong { get; set; }
        public short esShort { get; set; }
        public string cadena { get; set; }

        public Variables()
        {
            //Inicializo las variables con valores por defecto
            this.boleano = true;
            this.esByte = 255;
            this.caracter = 'a';
            this.esDecimal = 1.5m;
            this.esDouble = 5.5;
            this.esFloat = 1.52f;
            this.esInt = 10;
            this.esLong = 12345689123456789;
            this.esShort = 1234;
            this.cadena = "Hola Mundo";
        }

        //Creo un metodo para imprimir variables por pantalla
        public void MostrarVariables()
        {
            Console.WriteLine("Boleano: " + this.boleano);
            Console.WriteLine("Byte: " + this.esByte);
            Console.WriteLine("Caracter: " + this.caracter);
            Console.WriteLine("Decimal: " + this.esDecimal);
            Console.WriteLine("Double: " + this.esDouble);
            Console.WriteLine("Float: " + this.esFloat);
            Console.WriteLine("Int: " + this.esInt);
            Console.WriteLine("Long: " + this.esLong);
            Console.WriteLine("Short: " + this.esShort);
            Console.WriteLine("Cadena: " + this.cadena);
            Console.WriteLine("--------------------------------");


        }

        //5 - Creo un metodo para mostrar los valores minimos
        public void MostrarMinimo()
        {
            Console.WriteLine("Byte minimo: " + byte.MinValue);
            Console.WriteLine("Decimal minimo: " + decimal.MinValue);
            Console.WriteLine("Duble minimo: " + double.MinValue);
            Console.WriteLine("Float minimo: " + float.MinValue);
            Console.WriteLine("Int minimo: " + int.MinValue);
            Console.WriteLine("Long minimo: " + long.MinValue);
            Console.WriteLine("Short minimo: " + short.MinValue);
            Console.WriteLine("--------------------------------");
        }

        //Creo un metodo para mostrar los valores maximos
        public void MostrarMaximo()
        {
            Console.WriteLine("Byte maximo: " + byte.MaxValue);
            Console.WriteLine("Decimal maximo: " + decimal.MaxValue);
            Console.WriteLine("Duble maximo: " + double.MaxValue);
            Console.WriteLine("Float maximo: " + float.MaxValue);
            Console.WriteLine("Int maximo: " + int.MaxValue);
            Console.WriteLine("Long maximo: " + long.MaxValue);
            Console.WriteLine("Short maximo: " + short.MaxValue);
            Console.WriteLine("--------------------------------");
        }




    }
}
