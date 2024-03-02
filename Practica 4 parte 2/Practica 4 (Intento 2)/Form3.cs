using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string GetContenido()
        {
            return textBox1.Text;
        }
        public void SetContenido(string contenido)
        {
            // Establece el contenido del TextBox
            textBox1.Text = contenido;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
