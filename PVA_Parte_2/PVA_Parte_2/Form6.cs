using PVA_Parte_2.masterDataSetTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 
Pasos para conectarse:

- Ver
- Otras ventanas
- Origenes de datos
- En el cuadro de la izquierdad darle al barril con un +
- Seleccionar base de datos
- Seleccionar Conjunto de datos
- Le das a siguiente
- La guarda con el nombre que quieras
- Selecciona la tabla de tu base de datos
- Y le das a finalizar

*/


/*
 
    Cuando estes en diseño, si le das al desplegable que te sale al lado del nombre de la base de datos que está en Origen de datos.
    Le activas la opcion detalles. Y ahora arrastras la tabla dentro del form diseño, para así poder ver el contenido de la base de datos.

 */




namespace PVA_Parte_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Coches' Puede moverla o quitarla según sea necesario.
            this.cochesTableAdapter.Fill(this.masterDataSet.Coches);

        }

        private void cochesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cochesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void marcaTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void marcaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (marcaTextBox.Text.Length == 0)
            {
                //Se cancela el evento
                e.Cancel = true;
                MessageBox.Show("No ha de dejar vacío el campo");
            }
            else
            {
                e.Cancel = false;
            }

            //En la propiedad del Formulario “AutoValidate” la ponemos a “EnableAllowFocusChange” si queremos que permita salir del textbox

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cochesTableAdapter.FillByMarca(masterDataSet.Coches, textBox1.Text);
            if (masterDataSet.Coches.Count > 0)
            {
                label2.Text = masterDataSet.Coches[0].Patrocinadores;
            }
            else
            {
                MessageBox.Show("No se han encontrado coincidencias.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
