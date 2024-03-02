using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using static Practica_4__Intento_2_.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Practica_4;

namespace Practica_4__Intento_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Nuevo_Click(object sender, EventArgs e)
        {
            Form2 objetohijo = new Form2();
            objetohijo.MdiParent = this;
            objetohijo.Show();

            StreamWriter fichero = new StreamWriter(@"..\ficheroLog.txt", true);
            fichero.WriteLine("[" + DateTime.Now + "] Nuevo fichero.");
            fichero.Close();
            fichero.Dispose();
        }


        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objetohijo = new Form2();
            objetohijo.MdiParent = this;
            objetohijo.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Form2 objetohijo = this.ActiveMdiChild as Form2;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objetohijo = (Form2)this.ActiveMdiChild;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void minimizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Minimized;
            }
        }

        private void maximizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Maximized;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdabrir = new OpenFileDialog();
            ofdabrir.Filter = "Documento de texto (*.txt)|*.txt|Documento RTF (*.rtf)|*.rtf";
            ofdabrir.Title = "Abrir documento";

            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofdabrir.FileName);

                if (extension.ToLower() == ".txt")
                {
                    Form3 formHijo = new Form3();
                    formHijo.MdiParent = this;
                    formHijo.SetContenido(File.ReadAllText(ofdabrir.FileName));
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
                else if (extension.ToLower() == ".rtf")
                {
                    Form2 formHijo = new Form2();
                    formHijo.MdiParent = this;
                    formHijo.txbDocumento.LoadFile(ofdabrir.FileName);
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdabrir = new OpenFileDialog();
            ofdabrir.Filter = "Documento de texto (*.txt)|*.txt|Documento RTF (*.rtf)|*.rtf";
            ofdabrir.Title = "Abrir documento";

            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofdabrir.FileName);

                if (extension.ToLower() == ".txt")
                {
                    Form3 formHijo = new Form3();
                    formHijo.MdiParent = this;
                    formHijo.SetContenido(File.ReadAllText(ofdabrir.FileName));
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
                else if (extension.ToLower() == ".rtf")
                {
                    Form2 formHijo = new Form2();
                    formHijo.MdiParent = this;
                    formHijo.txbDocumento.LoadFile(ofdabrir.FileName);
                    formHijo.Text = Path.GetFileName(ofdabrir.FileName);
                    formHijo.Show();
                }
            }

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el formulario hijo actual
                Form formHijo = this.ActiveMdiChild;

                // Comprobar si el formulario hijo contiene un RichTextBox
                if (formHijo.GetType() == typeof(Form2))
                {
                    // Guardar como RTF
                    Form2 formRichTextBox = (Form2)formHijo;
                    formRichTextBox.txbDocumento.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    formRichTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
                // Comprobar si el formulario hijo contiene un TextBox
                else if (formHijo.GetType() == typeof(Form3))
                {
                    // Guardar como texto plano
                    Form3 formTextBox = (Form3)formHijo;
                    File.WriteAllText(saveFileDialog1.FileName, formTextBox.GetContenido());
                    formTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el formulario hijo actual
                Form formHijo = this.ActiveMdiChild;

                // Comprobar si el formulario hijo contiene un RichTextBox
                if (formHijo.GetType() == typeof(Form2))
                {
                    // Guardar como RTF
                    Form2 formRichTextBox = (Form2)formHijo;
                    formRichTextBox.txbDocumento.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    formRichTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
                // Comprobar si el formulario hijo contiene un TextBox
                else if (formHijo.GetType() == typeof(Form3))
                {
                    // Guardar como texto plano
                    Form3 formTextBox = (Form3)formHijo;
                    File.WriteAllText(saveFileDialog1.FileName, formTextBox.GetContenido());
                    formTextBox.Text = Path.GetFileName(saveFileDialog1.FileName); // Actualizar el título del formulario
                }
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modifica el tamaño, tipo estilo de la letra.
            //1. Creamos el objeto fuente.
            FontDialog fuente = new FontDialog();
            fuente.ShowDialog();
            //2. Especificamos el tipo de fuente a elegir. (=fontDialog.OK)
            Form2 objetoHijo = (Form2)this.ActiveMdiChild;
            objetoHijo.txbDocumento.SelectionFont = fuente.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modifica el color de la letra.
            //1. Creamos un objeto color fuente.
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            //2. Le asignamos el nuevo color a lo seleccionado en el RichTextBox.
            Form2 objetoHijo = (Form2)this.ActiveMdiChild;
            objetoHijo.txbDocumento.SelectionColor = color.Color;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Desacer_Click(object sender, EventArgs e)
        {
            Form2 objetoHijo = (Form2)this.ActiveMdiChild;
            objetoHijo.txbDocumento.Undo();

        }

        private void nevaimagen_Click(object sender, EventArgs e)
        {
            Form2 objetoHijo = (Form2)this.ActiveMdiChild;
            if (objetoHijo != null)
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    Image imgagen_a_insertar = Image.FromFile(openFileDialog3.FileName);
                    Clipboard.SetImage(imgagen_a_insertar);
                    objetoHijo.txbDocumento.Paste();
                    objetoHijo.txbDocumento.Focus();
                }
                else
                {
                    objetoHijo.txbDocumento.Focus();
                }
            }
            else
            {
                MessageBox.Show("No hay documento para insertar");
            }
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}


