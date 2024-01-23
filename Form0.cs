using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnombre_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Hola Mundo");
            }
            else { MessageBox.Show("Hola "+ txtnombre.Text); }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
           //Este botón cierra la aplicación
            Close();
        }
    }
}
