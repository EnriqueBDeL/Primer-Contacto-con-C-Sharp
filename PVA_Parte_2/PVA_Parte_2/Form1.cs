using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_Parte_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmsobreautor = new Form2();
            frmsobreautor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 frmsobreautor = new Form8();
            frmsobreautor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frmsobreautor = new Form4();
            frmsobreautor.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frmsobreautor = new Form5();
            frmsobreautor.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frmsobreautor = new Form6();
            frmsobreautor.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 frmsobreautor = new Form7();
            frmsobreautor.ShowDialog();
        }
    }
}
