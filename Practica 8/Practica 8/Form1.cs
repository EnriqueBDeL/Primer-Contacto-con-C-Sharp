using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Practica_8
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new
        SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");

        SqlCommand comandosql = new SqlCommand();

        SqlTransaction mitransaccion;

        int modo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvlistapalabras.Items.Clear();
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
            comandosql.CommandText = "SELECT esp,ing FROM traduccion";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string dato1;
            string dato2;
            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0); //palabra español
                                                   //Otra opción es: dato1 = midatareader["esp"].ToString();
                dato2 = midatareader.GetString(1); //palabra ingles
                ListViewItem milista = lvlistapalabras.Items.Add(dato1);
                milista.SubItems.Add(dato2);
            }
            midatareader.Close();
            conexion.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (modo == 0) // Si está en modo Añadir
            {
                string palabraEspañol = textBox1.Text;
                string palabraIngles = textBox2.Text;

                if (!string.IsNullOrEmpty(palabraEspañol) && !string.IsNullOrEmpty(palabraIngles))
                {
                    try
                    {
                        conexion.Open();
                        mitransaccion = conexion.BeginTransaction();
                        comandosql.Connection = conexion;
                        comandosql.Transaction = mitransaccion;
                        comandosql.CommandText = "INSERT INTO traduccion (esp, ing) VALUES (@esp, @ing)";
                        comandosql.Parameters.AddWithValue("@esp", palabraEspañol);
                        comandosql.Parameters.AddWithValue("@ing", palabraIngles);
                        comandosql.ExecuteNonQuery();
                        mitransaccion.Commit(); // Confirmar la transacción si todo va bien
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar la traducción: " + ex.Message);
                        mitransaccion.Rollback(); // Deshacer la transacción en caso de error
                    }
                    finally
                    {
                        conexion.Close();
                    }

                    // Agregar al ListView
                    ListViewItem nuevoItem = new ListViewItem(palabraEspañol);
                    nuevoItem.SubItems.Add(palabraIngles);
                    lvlistapalabras.Items.Add(nuevoItem);

                    // Limpiar los TextBox después de agregar
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una palabra en español e inglés.");
                }
            }
            else if (modo == 1) // Si está en modo Modificar
            {
                if (lvlistapalabras.SelectedItems.Count > 0)
                {
                    // Obtener el ítem seleccionado
                    ListViewItem selectedItem = lvlistapalabras.SelectedItems[0];

                    // Obtener los nuevos valores de la traducción en español e inglés desde los TextBox
                    string nuevoPalabraEspañol = textBox1.Text;
                    string nuevoPalabraIngles = textBox2.Text;

                    try
                    {
                        conexion.Open();
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "UPDATE traduccion SET esp = @nuevoEsp, ing = @nuevoIng WHERE esp = @viejoEsp AND ing = @viejoIng";
                        comandosql.Parameters.Clear(); // Limpiar los parámetros anteriores
                        comandosql.Parameters.AddWithValue("@nuevoEsp", nuevoPalabraEspañol);
                        comandosql.Parameters.AddWithValue("@nuevoIng", nuevoPalabraIngles);
                        comandosql.Parameters.AddWithValue("@viejoEsp", selectedItem.SubItems[0].Text);
                        comandosql.Parameters.AddWithValue("@viejoIng", selectedItem.SubItems[1].Text);
                        comandosql.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la traducción: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }

                    // Actualizar los valores en el ListView
                    selectedItem.SubItems[0].Text = nuevoPalabraEspañol;
                    selectedItem.SubItems[1].Text = nuevoPalabraIngles;

                    // Limpiar los TextBox después de modificar
                    textBox1.Clear();
                    textBox2.Clear();

                    // Restaurar el modo Añadir
                    modo = 0;
                    button2.Text = "Añadir";
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una traducción para modificar.");
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvlistapalabras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cambiar al modo Modificar
            modo = 1;
            button2.Text = "Modificar";

            if (lvlistapalabras.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                ListViewItem selectedItem = lvlistapalabras.SelectedItems[0];

                // Obtener los valores actuales de la traducción en español e inglés
                string palabraEspañolActual = selectedItem.SubItems[0].Text;
                string palabraInglesActual = selectedItem.SubItems[1].Text;

                // Actualizar los TextBox con los valores actuales
                textBox1.Text = palabraEspañolActual;
                textBox2.Text = palabraInglesActual;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una traducción para modificar.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lvlistapalabras.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                ListViewItem selectedItem = lvlistapalabras.SelectedItems[0];

                // Obtener los valores de la traducción en español e inglés
                string palabraEspañol = selectedItem.SubItems[0].Text;
                string palabraIngles = selectedItem.SubItems[1].Text;

                try
                {
                    conexion.Open();
                    comandosql.Connection = conexion;
                    comandosql.CommandText = "DELETE FROM traduccion WHERE esp = @esp AND ing = @ing";
                    comandosql.Parameters.AddWithValue("@esp", palabraEspañol);
                    comandosql.Parameters.AddWithValue("@ing", palabraIngles);
                    comandosql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la traducción: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }

                // Eliminar el ítem del ListView
                lvlistapalabras.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una traducción para eliminar.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             string idioma = comboBox1.SelectedItem?.ToString();
    string palabraBuscar = textBox3.Text.Trim();

    if (string.IsNullOrEmpty(palabraBuscar))
    {
        MessageBox.Show("Por favor, ingrese una palabra para buscar.");
        return;
    }

    if (string.IsNullOrEmpty(idioma))
    {
        MessageBox.Show("Por favor, seleccione un idioma para buscar.");
        return;
    }

    string campoBuscar = idioma == "Español" ? "esp" : "ing";

    try
    {
        lvlistapalabras.Items.Clear(); // Limpiar resultados anteriores

        conexion.Open();
        comandosql.Connection = conexion;
        comandosql.CommandText = $"SELECT esp, ing FROM traduccion WHERE {campoBuscar} = @palabra";

        // Limpiar parámetros anteriores
        comandosql.Parameters.Clear();

        // Agregar nuevo parámetro
        comandosql.Parameters.AddWithValue("@palabra", palabraBuscar);

        SqlDataReader midatareader = comandosql.ExecuteReader();
        while (midatareader.Read())
        {
            string dato1 = midatareader.GetString(0); // palabra español
            string dato2 = midatareader.GetString(1); // palabra ingles
            ListViewItem milista = lvlistapalabras.Items.Add(dato1);
            milista.SubItems.Add(dato2);
        }
        midatareader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al buscar la palabra: " + ex.Message);
    }
    finally
    {
        conexion.Close();
    }
        }
    }
    
}