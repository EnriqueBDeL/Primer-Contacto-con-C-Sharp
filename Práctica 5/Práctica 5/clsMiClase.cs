using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    public class Persona
    {
        // Creamos todos los getters y setters de los atributos de esta clase 


        private string p_dni;
        public string Dni { get { return p_dni; } set { p_dni = value; } }




        private string p_nombre;
        public string Nombre { get { return p_nombre; } set { p_nombre = value; } }



        private string p_apellido1;
        public string Apellido1 { get { return p_apellido1; } set { p_apellido1 = value; } }




        private string p_apellido2;
        public string Apellido2 { get { return p_apellido2; } set { p_apellido2 = value; } }




        private int p_edad;
        public int Edad { get { return p_edad; } set { if (value > 0) p_edad = value; } }

        // Creamos la funcion Suma
        public long Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        // Creamos un constructor vacio
        public Persona() { }

        // Creamos un constructor con todos los atributos
        public Persona(string a_dni, string a_nombre, string a_apellido1, string a_apellido2, int a_edad)
        {
            this.Dni = a_dni;
            this.Nombre = a_nombre;
            this.Apellido1 = a_apellido1;
            this.Apellido2 = a_apellido2;
            this.Edad = a_edad;
        }


    }
}
