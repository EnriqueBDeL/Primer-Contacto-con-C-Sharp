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
            ofdabrir.Filter = "Documento de texto (*.txt)|*.txt";
            ofdabrir.Title = "Abrir documento de Texto";

            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader textoarchivo = File.OpenText(ofdabrir.FileName))
                    {
                        Form2 form2 = new Form2(); // Crea una instancia de Form2
                        form2.textBox.Text = textoarchivo.ReadToEnd(); // Accede a Txtdocumento
                        form2.Show();


                        StreamWriter fichero = new StreamWriter(@"..\ficheroLog.txt", true);
                        fichero.WriteLine("[" + DateTime.Now + "] Fichero abierto.");
                        fichero.Close();
                        fichero.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofdabrir = new OpenFileDialog();
            ofdabrir.Filter = "Documento de texto (*.txt)|*.txt";
            ofdabrir.Title = "Abrir documento de Texto";
            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                string contenido = File.ReadAllText(ofdabrir.FileName);
                Form2 formHijoActivo = this.ActiveMdiChild as Form2;
                if (formHijoActivo != null)
                {
                    formHijoActivo.SetContenido(contenido);
                    formHijoActivo.Text = Path.GetFileName(ofdabrir.FileName);
                }
            }

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 hijoObjeto = (Form2)this.ActiveMdiChild;
            string sSelectedFile;
            if (((Form2)this.ActiveMdiChild) == null)

            {
                MessageBox.Show("No hay ningun formulario activo");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter documento = File.CreateText(saveFileDialog1.FileName);
                    documento.Write(hijoObjeto.textBox.Text);
                    documento.Close();


                    StreamWriter fichero = new StreamWriter(@"..\ficheroLog.txt", true);
                    fichero.WriteLine("[" + DateTime.Now + "] Fichero guardado.");
                    fichero.Close();
                    fichero.Dispose();
                }
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.ActiveControl.Font = new
                Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.ActiveControl.ForeColor =
                System.Drawing.SystemColors.ButtonFace;

        }
    }
}


