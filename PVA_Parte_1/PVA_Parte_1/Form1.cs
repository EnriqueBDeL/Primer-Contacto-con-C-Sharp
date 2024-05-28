using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_Parte_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Propiedad StartPosition del formulario, seleccionar CenterScreen.
        }
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para modificar texto, debes ir a propiedades y cambiar la fuente.", "Ayuda.",MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK; //Para comprobar el botón pulsado

            /*][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][
             
             Para ello utiliza el método MessageBox.Show().Por ejemplo, podemos llamarlo con la siguiente sintaxis:

                MessageBox.Show(Texto del mensaje, Título, Botones, Icono);
        Donde:
            
            Botones: (ejemplo: MessageBoxButtons.OKCancel)

             AbortRetryIgnore
             OK
             OKCancel
             YesNoCancel
             YesNo
             RetryCancel
            
            Icono: (ejemplo: MessageBoxIcon.Information)

             Exclamation
             Information
             None
             Question
             Stop
             Warning

            *///][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void buttonpacasa_Click(object sender, EventArgs e)
        {
            // Este boton cierra la aplicacion.
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("¿Tienes nombre?");
            }
            else
            {
                MessageBox.Show("Hola " + textBox1.Text);
            }
        }
 //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            //Muestra el cuadro de diálogo.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Cargar la imagen. Picfoto es el PictureBox.
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
 //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frmsobreautor = new Form2();
            frmsobreautor.ShowDialog();

        }
 //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void Entrar_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (comboBox1.Text == "") || (pictureBox1.Image == null))
            {
                MessageBox.Show("No rellenaste todo.");
            }
            else{

                Form3 frmsobreautor = new Form3();
                frmsobreautor.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frmsobreautor = new Form3();
            frmsobreautor.ShowDialog();
        }
    }
}
