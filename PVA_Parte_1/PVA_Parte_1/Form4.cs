using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PVA_Parte_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*  
             
                Lo primero que tendremos que hacer es activar el formulario principal para que sea
                de tipo MDI.Para ello, pondremos la propiedad IsMdiContainer a True.

            */

            this.IsMdiContainer = true;

        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas salir del Word 2.0?", "Cerrar.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             
                Si desplegamos el Menú “Ventana”, nos tiene que aparecer también el nombre de la lista
                de ventanas que se van creando. Para ello, tenemos que indicarlo en la propiedad
                MdiWindowListItem del componente MenuStrip que creamos al comienzo de la práctica.
                De la lista de componentes que se despliegan en la propiedad de MdiWindowListItem,
                asignaremos “ventanaToolStripMenuItem” para que sea en esta opción del menú en la que
                se muestre la lista de ventanas creadas

            */
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fhijo objetohijo = new fhijo();
            objetohijo.MdiParent = this;
            objetohijo.Show();
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fhijo objetohijo = new fhijo();
            objetohijo.MdiParent = this;
            objetohijo.Show();
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fhijo objetohijo = (fhijo)this.ActiveMdiChild;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void minimizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Minimized;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void maximizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Maximized;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
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

                        fhijo fhijo = new fhijo(); // Crea una instancia de fhijo
                        fhijo.textBox1.Text = textoarchivo.ReadToEnd(); // Accede a Txtdocumento
                        fhijo.Show();


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
        //------------------------------------------------------------------------------------------------------------------------------
        // Declaración de la referencia al formulario hijo
       //  private fhijo formularioHijo;
        //------------------------------------------------------------------------------------------------------------------------------
        private void toolStripButton2_Click(object sender, EventArgs e)
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
                        // Crear una instancia del formulario hijo
                        fhijo formularioHijo = new fhijo();

                        // Leer el contenido del archivo y asignarlo al textBox1 del formulario hijo
                        formularioHijo.textBox1.Text = textoarchivo.ReadToEnd();

                        // Establecer el formulario principal como contenedor MDI del formulario hijo
                        formularioHijo.MdiParent = this;

                        // Mostrar el formulario hijo dentro del contenedor MDI
                        formularioHijo.Show();

                        // Registrar en el log
                        using (StreamWriter fichero = new StreamWriter(@"..\ficheroLog.txt", true))
                        {
                            fichero.WriteLine("[" + DateTime.Now + "] Fichero abierto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            fhijo fhijo = (fhijo)this.ActiveMdiChild;

            if (((fhijo)this.ActiveMdiChild) == null)

            {
                MessageBox.Show("No hay ningun formulario activo");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter documento = File.CreateText(saveFileDialog1.FileName);
                    documento.Write(fhijo.textBox1.Text);
                    documento.Close();


                    StreamWriter fichero = new StreamWriter(@"..\ficheroLog.txt", true);
                    fichero.WriteLine("[" + DateTime.Now + "] Fichero guardado.");
                    fichero.Close();
                    fichero.Dispose();
                }
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.ActiveControl.Font = new
            Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
        }

        //------------------------------------------------------------------------------------------------------------------------------
        //  También se puede hacer con los cuadros de diálogo “ColorDialog” y “FontDialog”.
        //  Cambia el código anterior para que el usuario pueda seleccionar el tipo de fuente y color.
        //------------------------------------------------------------------------------------------------------------------------------

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.ActiveControl.ForeColor =
            System.Drawing.SystemColors.ButtonFace;
        }
      


       

     

        private void fuenteprimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void colorprimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

   

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    } 
}
 
