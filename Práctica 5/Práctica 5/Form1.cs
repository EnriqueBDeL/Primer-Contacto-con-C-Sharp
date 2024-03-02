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

namespace Práctica_5
{
    public partial class Form1 : Form
    {
        public List<Persona> lista;
        public Form1()
        {
            lista = new List<Persona>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textDNI.Text == "" || textNOMBRE.Text == "" || textAPELLIDO1.Text == "" || textAPELLIDO2.Text == "" || textEDAD.Text == "")
            {
                MessageBox.Show("NO HAY DATOS PARA INSERTAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si en el boton pone "INSERTAR"
                if (button1.Text == "Insertar")
                {
                    // Creamos la persona
                    Persona persona = new Persona(textDNI.Text, textNOMBRE.Text, textAPELLIDO1.Text, textAPELLIDO2.Text, int.Parse(textEDAD.Text));

                    // La añadimos a la lista
                    lista.Add(persona);

                    // Creamos un item para la listView. Asignamos sus valores
                    ListViewItem milista = new ListViewItem(persona.Dni);
                    milista.SubItems.Add(persona.Nombre);
                    milista.SubItems.Add(persona.Apellido1);
                    milista.SubItems.Add(persona.Apellido2);
                    milista.SubItems.Add(persona.Edad.ToString());

                    // Añadimos el item de la ListView 
                    listView1.Items.Add(milista);

                    // Limpiamos todos los campos || Tambien podriamos usar .Clear() ||
                    textDNI.Text = "";
                    textNOMBRE.Text = "";
                    textAPELLIDO1.Text = "";
                    textAPELLIDO2.Text = "";
                    textEDAD.Text = "";

                    // Redirigimos el cursor al textbox del nombre
                    textDNI.Focus();
                }





                // Si en el boton pone "MODIFICAR"
                if (button1.Text == "Modificar")
                {
                    // Inicializamos la variable index
                    int index = 0;

                    // Asignamos a item la fila selecionada
                    ListViewItem item = listView1.SelectedItems[0];

                    // Para cada persona en la lista comprobamos que su Dni y Nombre coinciden con los del item asignado antes
                    foreach (Persona p in lista)
                    {
                        if (p.Nombre == item.SubItems[1].Text && p.Dni == item.SubItems[0].Text)
                        {
                            // Le asignamos a index el indice de la persona que cumpla la anterior condición
                            index = lista.IndexOf(p);
                            break;
                        }
                    }

                    // Le asignamos los valores del item a los textboxs
                    item.SubItems[0].Text = textDNI.Text;
                    item.SubItems[1].Text = textNOMBRE.Text;
                    item.SubItems[2].Text = textAPELLIDO1.Text;
                    item.SubItems[3].Text = textAPELLIDO2.Text;
                    item.SubItems[4].Text = textEDAD.Text;

                    // Creamos la persona con las modificaciones 
                    Persona nuevaPersona = new Persona(textDNI.Text, textNOMBRE.Text,textAPELLIDO1.Text, textAPELLIDO2.Text, int.Parse(textEDAD.Text));

                    // Y sobrescribimos la persona
                    lista[index] = nuevaPersona;

                    // Actualizamos la ListView
                    listView1.Refresh();

                    // Limpiomos todos los campos
                    textDNI.Text = "";
                    textNOMBRE.Text = "";
                    textAPELLIDO1.Text = "";
                    textAPELLIDO2.Text = "";
                    textEDAD.Text = "";

                    textDNI.Focus();
                }

            }

        }
        //Mostrar datos
        private void button2_Click(object sender, EventArgs e)
        {
            // Inicializamos esta variable "contador" para asignarle un número a cada persona que mostremos
            int i = 1;

            // Para cada persona en lista la mostramos en un MessageBox con todos sus datos
            foreach (Persona l in lista)
            {
                MessageBox.Show("\nDNI: " + l.Dni +"NOMBRE: " + l.Nombre + "\nPRIMER APELLIDO: " + l.Apellido1 + "\nSEGUNDO APELLIDO: " + l.Apellido2 + "\nEDAD: " + l.Edad, "PERSONA " + 1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                i++;
            }
        }
        //SUMA:
        private void button3_Click(object sender, EventArgs e)
        {
            // Si los campos estan limpios no podemos llamar a la funcion
            if (textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("NO HAY NUMEROS PARA SUMAR", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Creamos una nueva persona para llamar a la funcion 'Suma' y mostramos el resultado
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

        // Para que se accione la funcion del boton suma cuando le pulsamos al enter
        private void Suma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button3_Click(null, null);
            }
        }


        //CANCELAR
        private void button4_Click(object sender, EventArgs e)
        {
            // Limpiamos todos los campos
            textDNI.Text = "";
            textNOMBRE.Text = "";
            textAPELLIDO1.Text = "";
            textAPELLIDO2.Text = "";
            textEDAD.Text = "";

            // Cambiamos el nombre del boton 'Insertar'
            button1.Text = "Insertar";

            // Redirigimos el cursor
            textDNI.Focus();

            // Ocultamos y deshabilitamos el boton 'Cancelar'
            button3.Enabled = false;
            button3.Visible = false;
        }
        //SALIR
        private void button6_Click(object sender, EventArgs e)
        {
            // Comprobamos si quiere salir de la app
            if (MessageBox.Show("¿¿DESEAS SALIR DE LA APLICAIÓN??", "¿SEGURO?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Salimos de la app
                Application.Exit();
            }
        }


        private void Insertar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(null, null);
            }
        }


        // Creamos una referencia al formulario de 'Mantenimiento'
        public Mantenimiento Form2 { get; set; }

        //Mantenimiento
        private void button5_Click(object sender, EventArgs e)
        {
            // Comprobamos que haya rellenado los campos correspondientes
            if (textDNI.Text == "")
            {
                MessageBox.Show("NECESITAS UN DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicializamos una variable, que nos servira para saber cuando usamos el 'Insertar' en el formulario de 'Mantenimiento'
                int flag = 0;

                // Para cada persona vamos comprobando que si sus Dni's coinciden con el escrito
                foreach (Persona l in lista)
                {
                    // Modo "Modificar"
                    if (l.Dni == textDNI.Text)
                    {
                        flag = 1;

                        // Creamos un nuevo formulario de 'Mantenimiento'
                        Mantenimiento main = new Mantenimiento();

                        // Referenciamos los formularios de 'Mantenimiento'
                        Form2 = main;

                        // Rellenamos los campos del formulario de 'Mantenimiento' con sus correspondientes
                        Form2.textBox1.Text = l.Dni;
                        Form2.txtNom.Text = l.Nombre;
                        Form2.txtApellido1.Text = l.Apellido1;
                        Form2.txtApellido2.Text = l.Apellido2;
                        Form2.txtEdad.Text = l.Edad.ToString();

                        // Cambiamos el nombre del boton del formulario de 'Mantenimiento'
                        Form2.btnInsertar.Text = "MODIFICAR";

                        // Mostramos el formulario de 'Mantenimiento'
                        main.ShowDialog();

                        // Inicializamos y asignamos el indice de la persona que cumple la condición del principio
                        int index = lista.IndexOf(l);

                        // Creamos un item y le asignamos el valor del item del ListView en ese indice
                        ListViewItem pers = listView1.Items[index];

                        // Le asignamos a cada SubItem su dato correspondiente de los textbox's del formulario de 'Mantenimiento'
                        pers.SubItems[0].Text = Form2.textBox1.Text;
                        pers.SubItems[1].Text = Form2.txtNom.Text;
                        pers.SubItems[2].Text = Form2.txtApellido1.Text;
                        pers.SubItems[3].Text = Form2.txtApellido2.Text;
                        pers.SubItems[4].Text = Form2.txtEdad.Text;

                        // Sustituimos los valores de la persona situada en la lista en la posiscion del indice
                        // por los de la UNICA persona alamcenada en la lista de personas del formulario de 'Mantenimiento'

                        lista[index].Dni = Form2.listaPersonas[0].Dni;
                        lista[index].Nombre = Form2.listaPersonas[0].Nombre;
                        lista[index].Apellido1 = Form2.listaPersonas[0].Apellido1;
                        lista[index].Apellido2 = Form2.listaPersonas[0].Apellido2;
                        lista[index].Edad = Form2.listaPersonas[0].Edad;

                        // Limpiamos el textbox del Dni y actualizamos la ListView
                        textDNI.Clear();
                        listView1.Refresh();

                        break;
                    }
                }

                // En caso de que el 'flag' sea igual a 0, pasamos al modo "Insertar"
                if (flag == 0)
                {
                    if (MessageBox.Show("NO SE HA INCONTRADO NADIE CON DNI: " +
                        textDNI.Text + "\nDESEA AÑADIRLO??", "DNI NO ENCONTRADO",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Creamos un nuevo formulario de 'Mantenimiento'
                        Mantenimiento main = new Mantenimiento();

                        // Referenciamos los formularios de 'Mantenimiento'
                        Form2 = main;

                        // Rellenamos el textbox de Dni del formulario de 'Mantenimiento'
                        Form2.textBox1.Text = textDNI.Text;

                        // Cambiamos el nombre del boton del formulario de 'Mantenimiento'
                        Form2.btnInsertar.Text = "Insertar";

                        // Abrimos el formulario de 'Mantenimiento'
                        main.ShowDialog();

                        // Añadimos al ListView el item del formulario de 'Mantenimiento'
                        listView1.Items.Add(Form2.milistapublica);

                        // Añadimos a la lista cada persona almacenada en la lista del formulario de 'Mantenimiento'
                        foreach (Persona p in Form2.listaPersonas)
                        {
                            lista.Add(p);
                        }

                        // Limpiamos el textbox del Dni
                        textDNI.Clear();
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando hayan 1 o mas filas seleccionadas
            if (listView1.SelectedItems.Count > 0)
            {
                // Cambiamos el nombre del boton 'Insertar'
                button1.Text = "Modificar";

                // Asignamos a item la fila selecionada
                ListViewItem item = listView1.SelectedItems[0];

                // Asignamos a los campos sus valores correspondientes del item
                textDNI.Text = item.SubItems[0].Text;
                textNOMBRE.Text = item.SubItems[1].Text;
                textAPELLIDO1.Text = item.SubItems[2].Text;
                textAPELLIDO2.Text = item.SubItems[3].Text;
                textEDAD.Text = item.SubItems[4].Text.ToString();

                // Mostramos y habilitamos el boton 'Cancelar'
                button4.Enabled = true;
                button4.Visible = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
