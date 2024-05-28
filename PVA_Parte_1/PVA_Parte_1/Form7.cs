using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static PVA_Parte_1.Class2; //Recuerda poner el .Class2 (*)


namespace PVA_Parte_1
{
    public partial class Form7 : Form
    {
        List<Class2.vehículo> lista;
        private int selectedIndex = -1;
        public Form7()
        {
            InitializeComponent();
            lista = new List<Class2.vehículo> { };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIndex == -1)
                {
                    // Modo insertar
                    Class2.vehículo vh = new Class2.vehículo
                    {
                        Matricula = textBox2.Text,
                        Marca = textBox3.Text,
                        Modelo = comboBox1.Text,
                        Año = int.Parse(textBox4.Text),
                        Dni = textBox5.Text
                        
                    };

                    lista.Add(vh);

                    MessageBox.Show("Persona agregada correctamente");
                }

                // Limpiar los textBoxes
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                // Manejo de errores (por ejemplo, formato incorrecto en Edad)
                MessageBox.Show("Error al procesar los datos: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar el ListView antes de actualizarlo
            listView1.Items.Clear();

            // Agregar todos los elementos de la lista al ListView
            foreach (var vh in lista)
            {
                ListViewItem item = new ListViewItem(vh.Dni);
                item.SubItems.Add(vh.Matricula);
                item.SubItems.Add(vh.Marca);
                item.SubItems.Add(vh.Modelo);
                item.SubItems.Add(vh.Año.ToString());
                listView1.Items.Add(item);
            }

            // Opcional: Mostrar un mensaje de confirmación
            MessageBox.Show("Lista actualizada con todas las personas almacenadas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedCount = listView1.SelectedItems.Count;
            if (selectedCount > 0)
            {
                if (selectedCount == 1)
                {
                    // Eliminar el único elemento seleccionado sin confirmación
                    var item = listView1.SelectedItems[0];
                    string dni = item.SubItems[0].Text;

                    var vehiculo = lista.FirstOrDefault(v => v.Dni == dni);
                    if (vehiculo != null)
                    {
                        lista.Remove(vehiculo);
                        listView1.Items.Remove(item);
                        MessageBox.Show("Vehículo eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al encontrar el vehículo en la lista.");
                    }
                }
                else
                {
                    // Preguntar al usuario si desea eliminar los elementos seleccionados
                    var result = MessageBox.Show("¿Desea eliminar los vehículos seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Crear una lista para almacenar los vehículos a eliminar
                        List<vehículo> vehiculosAEliminar = new List<vehículo>();

                        // Recorrer los elementos seleccionados en el ListView
                        foreach (ListViewItem item in listView1.SelectedItems)
                        {
                            string dni = item.SubItems[0].Text;
                            var vehiculo = lista.FirstOrDefault(v => v.Dni == dni);

                            if (vehiculo != null)
                            {
                                vehiculosAEliminar.Add(vehiculo);
                            }
                        }

                        // Eliminar los vehículos de la lista
                        foreach (var vehiculo in vehiculosAEliminar)
                        {
                            lista.Remove(vehiculo);
                            var item = listView1.Items.Cast<ListViewItem>().FirstOrDefault(i => i.SubItems[0].Text == vehiculo.Dni);
                            if (item != null)
                            {
                                listView1.Items.Remove(item);
                            }
                        }

                        MessageBox.Show("Vehículos eliminados correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un vehículo para eliminar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string matricula = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Por favor, introduzca una matrícula.");
                return;
            }

            var vehiculo = lista.FirstOrDefault(v => v.Matricula == matricula);

            if (vehiculo != null)
            {
                Form8 form8 = new Form8(vehiculo);
                form8.Show();
            }
            else
            {
                MessageBox.Show("Vehículo no encontrado.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Mostrar el SaveFileDialog y verificar que el usuario no canceló
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Abrir el archivo para escribir
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    // Crear un StringBuilder para almacenar el contenido del archivo
                    StringBuilder sb = new StringBuilder();

                    // Recorrer la lista de vehículos y agregar su información al StringBuilder
                    foreach (var vh in lista)
                    {
                        sb.AppendLine($"DNI: {vh.Dni}");
                        sb.AppendLine($"Matrícula: {vh.Matricula}");
                        sb.AppendLine($"Marca: {vh.Marca}");
                        sb.AppendLine($"Modelo: {vh.Modelo}");
                        sb.AppendLine($"Año: {vh.Año}");
                        sb.AppendLine();
                    }

                    // Escribir el contenido en el archivo
                    writer.Write(sb.ToString());
                }

                // Mostrar un mensaje de confirmación al usuario
                MessageBox.Show("Lista guardada correctamente en un archivo RTF.");
            }
        }
    }
    
    
}
