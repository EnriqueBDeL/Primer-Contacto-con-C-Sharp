using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult borrar = MessageBox.Show("Estas seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (borrar == DialogResult.OK) { tvarbol.Nodes.Clear(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtinsertar.Text == "")
            {
                MessageBox.Show("Escrie el texto a insertar");
            }
            else
            {

                if (rbrama.Checked)
                {
                    tvarbol.Nodes.Add(txtinsertar.Text);
                    txtinsertar.Text = "";
                }
                else
                {
                    TreeNode padre;
                    padre = tvarbol.SelectedNode;
                    padre.Nodes.Add(txtinsertar.Text);
                    txtinsertar.Text = "";
                    tvarbol.ExpandAll();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tvarbol.SelectedNode != null)
            {
                tvarbol.Nodes.Remove(tvarbol.SelectedNode);

            }
            else
            {

                MessageBox.Show("Seleccione el nodo a borrar");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tvarbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DNI_Click(object sender, EventArgs e)
        {

        }

        private void rbc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbchico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btinsertarlista_Click(object sender, EventArgs e)
        {
            if(txtdni.Text=="" || txtnombre.Text=="" || txttlfno.Text == "")
            {

                MessageBox.Show("Campos incomletos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int indice = 1;
                if (rbchico.Checked)
                {
                    indice = 0;
                }



                ListViewItem milista;
                milista = lvwlista.Items.Add(txtdni.Text,indice);
                milista.SubItems.Add(txtnombre.Text);
                milista.SubItems.Add(txttlfno.Text);
                txtdni.Text = "";
                txtnombre.Text = "";
                txttlfno.Text = "";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnborrarlista_Click(object sender, EventArgs e)
        {
            int totalfilas = lvwlista.SelectedItems.Count;
            for(int i = totalfilas-1; i>=0; i--)
            {

                lvwlista.Items.Remove(lvwlista.SelectedItems[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          DialogResult borrar = MessageBox.Show("Está seguro?","Borrar Lista", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(borrar == DialogResult.OK) { lvwlista.Items.Clear(); }
        }

        private void lvwlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbrama_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
