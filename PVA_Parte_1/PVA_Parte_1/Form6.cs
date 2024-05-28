using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PVA_Parte_1.Class1;
namespace PVA_Parte_1
{
    public partial class Form6 : Form
    {
        List<Class1.Persona> lista;
        private int selectedIndex = -1;

        public Form6()
        {
            InitializeComponent();
            lista = new List<Class1.Persona> { };
            button6.Visible = false; // Asegurarse de que el botón de cancelar no sea visible al inicio
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar el ListView antes de actualizarlo
            listView1.Items.Clear();

            // Agregar todos los elementos de la lista al ListView
            foreach (var persona in lista)
            {
                ListViewItem item = new ListViewItem(persona.Dni);
                item.SubItems.Add(persona.Nombre);
                item.SubItems.Add(persona.Apellido1);
                item.SubItems.Add(persona.Apellido2);
                item.SubItems.Add(persona.Edad.ToString());
                listView1.Items.Add(item);
            }

            // Opcional: Mostrar un mensaje de confirmación
            MessageBox.Show("Lista actualizada con todas las personas almacenadas");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIndex == -1)
                {
                    // Modo insertar
                    Class1.Persona persona = new Class1.Persona
                    {
                        Dni = textBox1.Text,
                        Nombre = textBox2.Text,
                        Apellido1 = textBox3.Text,
                        Apellido2 = textBox4.Text,
                        Edad = int.Parse(textBox5.Text)
                    };

                    lista.Add(persona);

                    MessageBox.Show("Persona agregada correctamente");
                }
                else
                {
                    // Modo modificar
                    var persona = lista[selectedIndex];
                    persona.Dni = textBox1.Text;
                    persona.Nombre = textBox2.Text;
                    persona.Apellido1 = textBox3.Text;
                    persona.Apellido2 = textBox4.Text;
                    persona.Edad = int.Parse(textBox5.Text);

                    MessageBox.Show("Persona modificada correctamente");

                    // Restablecer el estado
                    selectedIndex = -1;
                    button1.Text = "Insertar";
                    button6.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Si los campos están vacíos, no se puede llamar a la función
            if (textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("NO HAY NUMEROS PARA SUMAR", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Creamos una nueva persona para llamar a la función 'Suma' y mostramos el resultado
            else
            {
                Persona total = new Persona();
                long lasuma = total.Suma(int.Parse(textBox6.Text), int.Parse(textBox7.Text));
                MessageBox.Show(lasuma.ToString(), "TOTAL", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            // Limpiamos los campos
            textBox6.Text = "";
            textBox7.Text = "";

            // Redirigimos el cursor 
            textBox6.Focus();
        }

        private void buttonpacasa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Construir la cadena de texto con la información de cada persona en la lista
            StringBuilder preview = new StringBuilder();

            foreach (var persona in lista)
            {
                preview.AppendLine($"\n\nDNI: {persona.Dni},\nNombre: {persona.Nombre},\nApellido1: {persona.Apellido1},\nApellido2: {persona.Apellido2},\nEdad: {persona.Edad}");
            }

            // Mostrar la previsualización en un MessageBox
            MessageBox.Show(preview.ToString(), "Previsualización de la Lista");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                selectedIndex = listView1.SelectedItems[0].Index;
                var selectedPersona = lista[selectedIndex];

                textBox1.Text = selectedPersona.Dni;
                textBox2.Text = selectedPersona.Nombre;
                textBox3.Text = selectedPersona.Apellido1;
                textBox4.Text = selectedPersona.Apellido2;
                textBox5.Text = selectedPersona.Edad.ToString();

                button1.Text = "Modificar";
                button6.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            selectedIndex = -1;
            button1.Text = "Insertar";
            button6.Visible = false;
        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}