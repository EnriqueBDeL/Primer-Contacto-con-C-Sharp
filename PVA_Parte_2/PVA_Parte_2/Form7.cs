using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------------------------------- //Para utilizar Lin1
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//----------------------------------//Para utilizar XML
using System.Xml.Linq;
//----------------------------------


namespace PVA_Parte_2
{
    public partial class Form7 : Form
    {
        string[] alumnos = { "Juan", "Lucía", "Pedro", "Antonio", "Pablo", "María" };

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

    

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar el listBox antes de añadir los elementos filtrados
            listBox2.Items.Clear();

            // Obtener la letra introducida en el textBox
            string letra = textBox2.Text;

            if (!string.IsNullOrEmpty(letra) && letra.Length == 1)
            {
                var alumnosseleccionados = from busca in alumnos
                                           where busca.StartsWith(letra, StringComparison.OrdinalIgnoreCase)
                                           orderby busca
                                           select busca.ToUpper();
                // Lo metemos en un listbox
                foreach (var un_alumno in alumnosseleccionados)
                {
                    listBox2.Items.Add(un_alumno);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una única letra para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var alumnosseleccionados = from busca in alumnos
                                       where busca.StartsWith("P")
                                       orderby busca
                                       select busca.ToUpper();
            //Lo metemos en un listbox
            foreach (var un_alumno in alumnosseleccionados)
            {
                listBox2.Items.Add(un_alumno);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo XML
                string rutaArchivoXML = @"C:\Users\admin\Desktop\Trabajos Visual Studio\PVA_Parte_2\EjemploXML.xml";

                // Verificar si el archivo existe
                if (!System.IO.File.Exists(rutaArchivoXML))
                {
                    MessageBox.Show("El archivo XML no se encontró en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cargar el archivo XML
                XDocument documentoXML = XDocument.Load(rutaArchivoXML);

                // Obtener la asignatura seleccionada en el ComboBox
                string asignaturaSeleccionada = comboBox1.SelectedItem.ToString().ToUpper();

                // Realizar la consulta LINQ
                var alumnosSeleccionados = from datos in documentoXML.Descendants("nota")
                                           where datos.Attribute("asignatura").Value.ToString().ToUpper() == asignaturaSeleccionada
                                           select new
                                           {
                                               nifalumno = datos.Element("nif").Value,
                                               calificacionalumno = datos.Element("calificacion").Value
                                           };

                // Limpiar el ListBox antes de agregar nuevos elementos
                listBox1.Items.Clear();

                // Recuperar la consulta y mostrar los resultados en el ListBox
                foreach (var el_alumno in alumnosSeleccionados)
                {
                    listBox1.Items.Add(el_alumno.nifalumno + " " + el_alumno.calificacionalumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
