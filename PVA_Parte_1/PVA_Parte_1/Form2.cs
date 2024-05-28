using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_Parte_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Para escribir mas de una lineas tiens que escribir en la opcion Lines String[] Arrays
           // ReadOnly en true para hacer que no se pueda escribir
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por confiar en este codigo. Pulse aceptar y salir para continuar", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
