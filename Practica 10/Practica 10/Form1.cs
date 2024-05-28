using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Practica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] alumnos = { "Juan", "Lucía", "Pedro", "Antonio", "Pablo", "María" };


            var alumnosseleccionados = from busca in alumnos
                                       where busca.StartsWith("P")
                                       orderby busca
                                       select busca.ToUpper();

            foreach (var un_alumno in alumnosseleccionados)
            {
                listBox1.Items.Add(un_alumno);
            }


            //------------------------------------------------------------------------------------------



            XDocument documentoXML = XDocument.Load(@"C:\Users\admin\Desktop\Trabajos Visual Studio\Practica 10\EjemploXML.xml");
            var alumnosSeleccionados = from datos in documentoXML.Descendants("nota")
                                       where datos.Attribute("asignatura").Value.ToString().ToUpper() == "PVA"
                                       select new
                                       {
                                           nifalumno = datos.Element("nif").Value,
                                           calificacionalumno = datos.Element("calificacion").Value
                                       };


            // Recuperamos la consulta y la mostramos en un listbox.
            foreach (var el_alumno in alumnosSeleccionados)
            {
                listBox2.Items.Add(el_alumno.nifalumno + " " +
                el_alumno.calificacionalumno);
            }







        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
