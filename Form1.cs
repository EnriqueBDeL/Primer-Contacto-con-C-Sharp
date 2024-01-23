using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaPersonal
{
    public partial class FICHA_PERSONAL : Form
    {
        public FICHA_PERSONAL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text == "") || (txtdireccion.Text == "") || (cbciudad.Text == ""))
            {
                MessageBox.Show("Ha de rellenar el formulario.");
            }
            else
            {
                MessageBox.Show("Los datos se han rellenado correctamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = null;
            txtdireccion.Text = null;
            cbciudad.Text = null;
            picfoto.Image = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ofdfoto.ShowDialog() == DialogResult.OK)
            {
                picfoto.Image = Image.FromFile(ofdfoto.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtdireccion.Focus();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
