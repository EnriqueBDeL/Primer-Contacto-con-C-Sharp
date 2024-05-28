using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PVA_Parte_1
{
    public partial class fhijo : Form
    {
        public fhijo()
        {
            InitializeComponent();
        }

        private void fhijo_Load(object sender, EventArgs e)
        {

        }
        public string GetContenido()
        {
            return textBox1.Text;
        }

        public void SetContenido(string contenido)
        {
            textBox1.Text = contenido;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Para que el textBox ocupe todo tienes que poner la opcion Dock en Fill.
        }
    }
}
