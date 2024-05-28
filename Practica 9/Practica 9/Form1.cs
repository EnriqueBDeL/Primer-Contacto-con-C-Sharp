using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void traduccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traduccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pvadsdiccionario);

        }

        private void traduccionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.traduccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pvadsdiccionario);

        }

        private void traduccionBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.traduccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pvadsdiccionario);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pvadsdiccionario.traduccion' Puede moverla o quitarla según sea necesario.
            this.traduccionTableAdapter.Fill(this.pvadsdiccionario.traduccion);

        }

        private void espTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void espTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (espTextBox.Text.Length == 0)
            {
                //Se cancela el evento
                e.Cancel = true;
                MessageBox.Show("No ha de dejar vacío el campo");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            traduccionTableAdapter.FillByesp(pvadsdiccionario.traduccion, textBox1.Text);
            if(pvadsdiccionario.traduccion.Count > 0)
            {
                lbling.Text = pvadsdiccionario.traduccion[0].ing;
            }
            else 
            {
                MessageBox.Show("No se han encontrado coincidencias.");
            }
        }
    }
}
