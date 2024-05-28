using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Parte_1
{
    internal class Class1
    {


        public class Persona
        {
            // Getters y setters para los atributos de esta clase
            public string Dni { get; set; }
            public string Nombre { get; set; }
            public string Apellido1 { get; set; }
            public string Apellido2 { get; set; }
            public int Edad { get; set; }

            // Función Suma
            public long Suma(int num1, int num2)
            {
                return num1 + num2;
            }

            // Constructor con todos los atributos
            public Persona(string dni, string nombre, string apellido1, string apellido2, int edad)
            {
                Dni = dni;
                Nombre = nombre;
                Apellido1 = apellido1;
                Apellido2 = apellido2;
                Edad = edad;
            }

            // Constructor por defecto
            public Persona() { }
        }
    }


}

