using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_5
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cerramos la ventana
            Close();
        }

        // Creamos un ListViewItem y una Lista publicos 
        public ListViewItem milistapublica;
        public List<Persona> listaPersonas;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Modo "Insertar"
            if (btnInsertar.Text == "INSERTAR")
            {
                if (textBox1.Text == "" || txtNom.Text == "" || txtApellido1.Text == "" || txtApellido2.Text == "" ||
                    txtEdad.Text == "")
                {
                    MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS!!", "INCOMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Creamos una nueva lista donde almacenar la persona a insertar
                    listaPersonas = new List<Persona>();

                    // Creamos la persona
                    Persona persona = new Persona(textBox1.Text, txtNom.Text,
                        txtApellido1.Text, txtApellido2.Text, int.Parse(txtEdad.Text));

                    // Añadimos la persona a la lista
                    listaPersonas.Add(persona);

                    // Creamos un item para la listView. Asignamos sus valores
                    ListViewItem milista = new ListViewItem(persona.Dni);
                    milista.SubItems.Add(persona.Nombre);
                    milista.SubItems.Add(persona.Apellido1);
                    milista.SubItems.Add(persona.Apellido2);
                    milista.SubItems.Add(persona.Edad.ToString());

                    // Igualamos los items de listView 
                    milistapublica = milista;

                    Close();
                }

            }
            // Modo "Modificar"
            if (btnInsertar.Text == "MODIFICAR")
            {
                if (textBox1.Text == "" && txtNom.Text == "" && txtApellido1.Text == "" &&
                    txtApellido2.Text == "" && txtEdad.Text == "")
                {
                    MessageBox.Show("NO PUEDE DEJAR LOS CAMPOS VACIOS", "INCOMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else
                {
                    // Creamos una nueva lista donde almacenar la persona a modificar
                    listaPersonas = new List<Persona>();

                    // Creamos la persona 
                    Persona persona = new Persona(textBox1.Text, txtNom.Text,
                        txtApellido1.Text, txtApellido2.Text, int.Parse(txtEdad.Text));

                    // Añadimos la persona a la lista
                    listaPersonas.Add(persona);

                    Close();
                }
            }

        }
        private void Insertar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnInsertar_Click(null, null);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido2_Click(object sender, EventArgs e)
        {

        }
    }
}
