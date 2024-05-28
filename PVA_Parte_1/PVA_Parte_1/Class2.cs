using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Parte_1
{
    internal class Class2
    {

        public class vehículo
        {
            public string Matricula { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }
            public string Dni { get; set; }


            public vehículo(string matricula, string marca, string modelo, int año, string dni)
            {
              
                Matricula = matricula;
                Marca = marca;
                Modelo = modelo;
                Año = año;
                Dni = dni;

            }

            public vehículo() { } //Recuerda poner vehículo (*)

        }
    }
}
