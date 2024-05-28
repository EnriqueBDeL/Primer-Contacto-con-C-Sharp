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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonpacasa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "" ){

                MessageBox.Show("Escribe algo para añadir.");
            }
            else{

                checkedListBox1.Items.Add ( textBox1.Text );

                // Obtener el índice del elemento recién agregado
                int nuevoIndice = checkedListBox1.Items.Count - 1;

                // Marcar el elemento recién agregado en checkedListBox1
                checkedListBox1.SetItemChecked(nuevoIndice, true);

                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
             DialogResult result = MessageBox.Show("¿Deseas eliminar tod la lista?", "Eliminar todo.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                checkedListBox1.Items.Clear();

            }

           

        }
//-----------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------ARBOL-------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            // Creamos una lista temporal para almacenar los índices de los elementos marcados
            List<int> itemsToRemove = new List<int>();

            // Iteramos sobre todos los elementos del CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Verificamos si el elemento en la posición actual está marcado
                if (checkedListBox1.GetItemChecked(i))
                {
                    // Si está marcado, agregamos el índice a la lista de elementos a eliminar
                    itemsToRemove.Add(i);
                }
            }

            // Iteramos en orden inverso para evitar problemas con los índices al eliminar
            for (int i = itemsToRemove.Count - 1; i >= 0; i--)
            {
                // Eliminamos el elemento marcado utilizando su índice
                checkedListBox1.Items.RemoveAt(itemsToRemove[i]);
            }

            // Mostrar mensaje de éxito
            MessageBox.Show("Elementos marcados eliminados correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 //-----------------------------------------------------------------------------------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // Si el radioButton1 está seleccionado, añadimos el texto del textBox2 como una nueva rama
                treeView1.Nodes.Add(textBox2.Text);
            }
            else if (radioButton2.Checked == true)
            {
                // Si el radioButton2 está seleccionado, añadimos el texto del textBox2 como un hijo del nodo seleccionado
                TreeNode objNode;
                objNode = treeView1.SelectedNode;
                objNode.Nodes.Add(textBox2.Text);
            }



        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
           

            DialogResult result = MessageBox.Show("¿Deseas eliminar todo el arbol?", "Eliminar todo.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                treeView1.Nodes.Clear();
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------LISTA-------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void label3_Click(object sender, EventArgs e)
        {

        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Para añadir las columnas tienes que entrar en la opcion Columns

            // Si quieres que se vean los iconos en la lista tienes que poner en smalllmagelist el imageList1.
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {

                MessageBox.Show("Campos incomletos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int indice = 1;
                if (radioButton3.Checked)
                {
                    indice = 0;
                }



                ListViewItem milista;
                milista = listView1.Items.Add(textBox3.Text, indice);
                milista.SubItems.Add(textBox4.Text);
                milista.SubItems.Add(textBox5.Text);


                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("¿Deseas eliminar toda la lista?", "Eliminar todo.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
         
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int totalfilas = listView1.SelectedItems.Count;
            for (int i = totalfilas - 1; i >= 0; i--)
            {

                listView1.Items.Remove(listView1.SelectedItems[i]);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Para poner un icono tienes que hacer un imagelist y ponerlo en el imagelist del boton


            // en el imagelist tienes que metr las fotos en imagenes
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            Form4 frmsobreautor = new Form4();
            frmsobreautor.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 frmsobreautor = new Form5();
            frmsobreautor.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form6 frmsobreautor = new Form6();
            frmsobreautor.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 frmsobreautor = new Form7();
            frmsobreautor.ShowDialog();
        }
    }
}
