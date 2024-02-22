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
    public partial class Licencia : Form
    {
        public Licencia()
        {
            InitializeComponent();
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }
       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_cancelar.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto registrado");
            Close();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            btn_cancelar.Enabled = true;
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
