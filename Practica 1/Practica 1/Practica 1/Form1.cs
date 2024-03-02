using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Comprueba si las cajas de texto están vacías y muestra un mensaje.
            //Fíjate en el nombre de los componentes, por ejemplo en vez de txtnombre utiliza el que hayas puesto.
        if ((textBoxNombre.Text == "") || (textBoxDirección.Text == "") || (comboBoxCiudad.Text == ""))
            {
                MessageBox.Show("Ha de rellenar el formulario.");
            }
            else
            {
                MessageBox.Show("Los datos se han rellenado correctamente.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //Evento click.
            textBoxNombre.Text = null;
            textBoxDirección.Text = null;
            comboBoxCiudad.Text = null;
            pictureBox1.Image = null;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            //Muestra el cuadro de diálogo.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Cargar la imagen. Picfoto es el PictureBox.
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
         
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if ((textBoxNombre.Text == "") || (textBoxDirección.Text == "") || (comboBoxCiudad.Text == ""))
            {
                MessageBox.Show("Ha de rellenar el formulario.");
            }
            else
            {
                MessageBox.Show("Los datos se han rellenado correctamente.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                textBoxDirección.Focus();
            }
        }
    }
}
