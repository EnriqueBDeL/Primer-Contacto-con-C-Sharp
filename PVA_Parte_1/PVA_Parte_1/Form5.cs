using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_Parte_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdabrir = new OpenFileDialog();
            ofdabrir.Filter = "Documento de texto (*.txt)|*.txt|Documento RTF (*.rtf)|*.rtf";
            ofdabrir.Title = "Abrir documento";

            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofdabrir.FileName);

                if (extension.ToLower() == ".txt")
                {
                    fhijo formHijo = new fhijo();
                    formHijo.MdiParent = this;
                    formHijo.SetContenido(File.ReadAllText(ofdabrir.FileName));
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
                else if (extension.ToLower() == ".rtf")
                {
                    fprimo formHijo = new fprimo();
                    formHijo.MdiParent = this;
                    formHijo.richTextBox1.LoadFile(ofdabrir.FileName);
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
            }

        }
            

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el formulario hijo actual
                Form formHijo = this.ActiveMdiChild;

                // Comprobar si el formulario hijo contiene un RichTextBox
                if (formHijo.GetType() == typeof(fprimo))
                {
                    // Guardar como RTF
                    fprimo formRichTextBox = (fprimo)formHijo;
                    formRichTextBox.richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    formRichTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
                // Comprobar si el formulario hijo contiene un TextBox
                else if (formHijo.GetType() == typeof(fhijo))
                {
                    // Guardar como texto plano
                    fhijo formTextBox = (fhijo)formHijo;
                    File.WriteAllText(saveFileDialog1.FileName, formTextBox.GetContenido());
                    formTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fprimo objetoPrimo = this.ActiveMdiChild as fprimo;
            if (objetoPrimo != null)
            {
                objetoPrimo.Close();
            }

            fhijo objetohijo = this.ActiveMdiChild as fhijo;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            fprimo objetoPrimo = this.ActiveMdiChild as fprimo;

            if (objetoPrimo != null)
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image imagen_a_insertar = Image.FromFile(openFileDialog3.FileName);
                        Clipboard.SetImage(imagen_a_insertar);
                        objetoPrimo.richTextBox1.Paste();
                        objetoPrimo.richTextBox1.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    objetoPrimo.richTextBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("No hay documento para insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {
                if (activeChild is fprimo)
                {
                    fprimo objetoPrimo = (fprimo)activeChild;
                    objetoPrimo.richTextBox1.Undo();
                }
                else if (activeChild is fhijo)
                {
                    fhijo objetoHijo = (fhijo)activeChild;
                    objetoHijo.textBox1.Undo();
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            fprimo objetoprimo = new fprimo();
            objetoprimo.MdiParent = this;
            objetoprimo.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas salir del Word 3.0?", "Cerrar.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fprimo objetoprimo = new fprimo();
            objetoprimo.MdiParent = this;
            objetoprimo.Show();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdabrir = new OpenFileDialog();
            ofdabrir.Filter = "Documento de texto (*.txt)|*.txt|Documento RTF (*.rtf)|*.rtf";
            ofdabrir.Title = "Abrir documento";

            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofdabrir.FileName);

                if (extension.ToLower() == ".txt")
                {
                    fhijo formHijo = new fhijo();
                    formHijo.MdiParent = this;
                    formHijo.SetContenido(File.ReadAllText(ofdabrir.FileName));
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
                else if (extension.ToLower() == ".rtf")
                {
                    fprimo formHijo = new fprimo();
                    formHijo.MdiParent = this;
                    formHijo.richTextBox1.LoadFile(ofdabrir.FileName);
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el formulario hijo actual
                Form formHijo = this.ActiveMdiChild;

                // Comprobar si el formulario hijo contiene un RichTextBox
                if (formHijo.GetType() == typeof(fprimo))
                {
                    // Guardar como RTF
                    fprimo formRichTextBox = (fprimo)formHijo;
                    formRichTextBox.richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    formRichTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
                // Comprobar si el formulario hijo contiene un TextBox
                else if (formHijo.GetType() == typeof(fhijo))
                {
                    // Guardar como texto plano
                    fhijo formTextBox = (fhijo)formHijo;
                    File.WriteAllText(saveFileDialog1.FileName, formTextBox.GetContenido());
                    formTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fprimo objetoPrimo = this.ActiveMdiChild as fprimo;
            if (objetoPrimo != null)
            {
                objetoPrimo.Close();
            }

            fhijo objetohijo = this.ActiveMdiChild as fhijo;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modifica el tamaño, tipo estilo de la letra.
            //1. Creamos el objeto fuente.
            FontDialog fuente = new FontDialog();
            fuente.ShowDialog();
            //2. Especificamos el tipo de fuente a elegir. (=fontDialog.OK)
            fprimo objetoPrimo = (fprimo)this.ActiveMdiChild;
            objetoPrimo.richTextBox1.SelectionFont = fuente.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modifica el color de la letra.
            //1. Creamos un objeto color fuente.
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            //2. Le asignamos el nuevo color a lo seleccionado en el RichTextBox.
            fprimo objetoHijo = (fprimo)this.ActiveMdiChild;
            objetoHijo.richTextBox1.SelectionColor = color.Color;
        }
    }
}
