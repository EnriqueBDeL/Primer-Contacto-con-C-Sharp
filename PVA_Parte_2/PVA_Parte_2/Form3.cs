using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------  Recuerda poner esto. (Si no agregas la referencia de excel no funionaran)
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
//-----------------------------------------------

//  (!!!) Recuerda que para agregar referencia Excel, tienes que ir a proyecto, agregar referencia, COM y marcar Microsoft Excel [versión] Object Library.

namespace PVA_Parte_2
{
    public partial class Form3 : Form
    {

        Excel.Application objExcel;
        Excel.Workbook objLibro;
        Excel.Worksheet objHoja;
        Excel.Range objRango;

        Excel.Application excelApp;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;

        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application objExcel = new Excel.Application();
            objExcel.Visible = true;

            Excel.Workbook objLibro = objExcel.Workbooks.Add(Missing.Value);
            Excel.Worksheet objHoja = (Excel.Worksheet)objLibro.Worksheets.get_Item(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            // Asegúrate de que los datos en las cajas de texto no estén vacíos antes de escribirlos en Excel
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor, introduce valores en las cajas de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application objExcel = new Excel.Application();
            objExcel.Visible = true;

            Excel.Workbook objLibro = objExcel.Workbooks.Add(Missing.Value);
            Excel.Worksheet objHoja = (Excel.Worksheet)objLibro.Worksheets.get_Item(1);

            objHoja.Cells[1, 1] = textBox1.Text; // Obtener el texto de textBox1
            objHoja.Cells[2, 1] = textBox2.Text; // Obtener el texto de textBox2



            objRango = objHoja.get_Range("C1", Missing.Value);
            objRango.Value = 10;

            objRango = objHoja.get_Range("C2", Missing.Value);
            objRango.Value = 10;

            objRango = objHoja.get_Range("C3", Missing.Value);
            objRango.Value = 0;
            objRango.NumberFormat = "0.00 €";
            objRango.FormulaLocal = "=SUMA(C1:C2)";
            objRango.AddComment(textBox3.Text);
            objRango.Font.Bold = true;




            /*
             
            Insertar en una celda (dos formas):

            ✓ Excel.Range objRango;
                 objRango = objHoja.get_Range("A1", Missing.Value);
                 objRango.Value =10;

            ✓ (Más intuitiva)

            objHoja.Cells[1, 1] = "DNI"; //Celda A1
            objHoja.Cells[2, 1] = 33256456; //Celda B1

             */




        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Excel|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet worksheet = workbook.Sheets[1];

                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;

                string content = "";

                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        content += worksheet.Cells[i, j].Value.ToString() + "\t";
                    }
                    content += Environment.NewLine;
                }

                textBox4.Text = content;

                workbook.Close(false);
                excelApp.Quit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
