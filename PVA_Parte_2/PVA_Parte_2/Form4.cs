using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
//-------------------------------------


//  (!!!) Recuerda que para agregar referencia Word, tienes que ir a proyecto, agregar referencia, COM y marcar Microsoft Word [versión] Object Library.


namespace PVA_Parte_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Esto abre Word
            Word.Application objWord = new Word.Application();
            objWord.Visible = true;


            //Esto crea un documento

            Word.Document objDocumento;
            objDocumento = objWord.Documents.Add(Missing.Value, Missing.Value,
            Missing.Value, Missing.Value);


            //Salir
            objWord.Quit();
            objWord = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            if (textBox1.Text != "")
            {

                //Esto abre Word
                Word.Application objWord = new Word.Application();
                objWord.Visible = true;

                //Esto crea un documento

                Word.Document objDocumento;
                objDocumento = objWord.Documents.Add(Missing.Value, Missing.Value,
                Missing.Value, Missing.Value);

                //Mensaje introducido
                objWord.Selection.TypeText(textBox1.Text);

            }
            else
            {
                MessageBox.Show("Introduce un mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            textBox1.Text = ("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents|*.docx";
            openFileDialog.Title = "Select a Word Document";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Open(openFileDialog.FileName);

                wordApp.Visible = true;

                // Imprimir el documento
                wordDoc.PrintOut();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents|*.docx";
            openFileDialog.Title = "Select a Word Document";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Open(openFileDialog.FileName);

                wordApp.Visible = true;

                // Mostrar la vista previa de impresión
                wordApp.ActiveWindow.ActivePane.View.Type = Word.WdViewType.wdPrintPreview;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de apertura de archivo
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de Word (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog1.Title = "Selecciona un documento de Word";

            // Mostrar el cuadro de diálogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado por el usuario
                string filePath = openFileDialog1.FileName;

                // Crear una instancia de la aplicación de Word
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false; // No mostrar la aplicación de Word al usuario

                // Abrir el documento de Word
                Word.Document doc = wordApp.Documents.Open(filePath);

                // Leer el contenido del documento
                string contenido = doc.Content.Text;

                // Cerrar el documento y la aplicación de Word
                doc.Close();
                wordApp.Quit();

                // Mostrar el contenido en el TextBox
                textBox2.Text = contenido;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
