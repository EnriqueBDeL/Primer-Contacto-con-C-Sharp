using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; //Si no pones esto no puedes usar archivos Xml



namespace PVA_Parte_2
{
    public partial class Form2 : Form
    {
        private XmlDocument xmlDoc;
        private string xmlFilePath = @"C:\Users\admin\Desktop\Trabajos Visual Studio\PVA_Parte_2\ejemplo_2.xml";

        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private string GetNodeInnerText(XmlElement parentNode, string nodeName)
        {
            XmlNodeList nodeList = parentNode.GetElementsByTagName(nodeName);
            return nodeList.Count > 0 ? nodeList[0].InnerText : string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML (*.xml)|*.xml",
                Title = "Seleccionar archivo XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = openFileDialog.FileName;
                xmlDoc = new XmlDocument();

                try
                {
                    xmlDoc.Load(xmlFilePath);

                    XmlNodeList titulo = xmlDoc.GetElementsByTagName("titulo");
                    if (titulo.Count > 0)
                    {
                        this.Text = titulo[0].InnerText;
                    }

                    XmlNodeList personas = xmlDoc.GetElementsByTagName("persona");
                    foreach (XmlElement personaNode in personas)
                    {
                        string nombre = GetNodeInnerText(personaNode, "nombre");
                        string apellido1 = GetNodeInnerText(personaNode, "apellido1");
                        string apellido2 = GetNodeInnerText(personaNode, "apellido2");

                        listBox1.Items.Add(nombre);
                        listBox1.Items.Add("\t" + apellido1);
                        listBox1.Items.Add("\t" + apellido2);

                        foreach (XmlElement telefonoNode in personaNode.GetElementsByTagName("telefono"))
                        {
                            listBox1.Items.Add("\t" + telefonoNode.InnerText);
                        }

                        foreach (XmlElement emailNode in personaNode.GetElementsByTagName("email"))
                        {
                            listBox1.Items.Add("\t" + emailNode.InnerText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un elemento del ListBox para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedText = listBox1.SelectedItem.ToString().Trim();
            string newText = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newText))
            {
                MessageBox.Show("Por favor, ingresa el nuevo texto en el TextBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                bool elementModified = false;

                XmlNodeList personas = xmlDoc.GetElementsByTagName("persona");
                foreach (XmlElement personaNode in personas)
                {
                    string nombre = GetNodeInnerText(personaNode, "nombre");
                    string apellido1 = GetNodeInnerText(personaNode, "apellido1");
                    string apellido2 = GetNodeInnerText(personaNode, "apellido2");

                    if (nombre.Equals(selectedText, StringComparison.OrdinalIgnoreCase))
                    {
                        personaNode.GetElementsByTagName("nombre")[0].InnerText = newText;
                        elementModified = true;
                    }
                    else if (apellido1.Equals(selectedText, StringComparison.OrdinalIgnoreCase))
                    {
                        personaNode.GetElementsByTagName("apellido1")[0].InnerText = newText;
                        elementModified = true;
                    }
                    else if (apellido2.Equals(selectedText, StringComparison.OrdinalIgnoreCase))
                    {
                        personaNode.GetElementsByTagName("apellido2")[0].InnerText = newText;
                        elementModified = true;
                    }
                }

                listBox1.Items.Clear(); // Limpiar ListBox antes de volver a agregar los elementos actualizados

                // Volver a cargar los elementos actualizados en el ListBox
                foreach (XmlElement personaNode in personas)
                {
                    string nombre = GetNodeInnerText(personaNode, "nombre");
                    string apellido1 = GetNodeInnerText(personaNode, "apellido1");
                    string apellido2 = GetNodeInnerText(personaNode, "apellido2");

                    listBox1.Items.Add(nombre);
                    listBox1.Items.Add("\t" + apellido1);
                    listBox1.Items.Add("\t" + apellido2);

                    foreach (XmlElement telefonoNode in personaNode.GetElementsByTagName("telefono"))
                    {
                        listBox1.Items.Add("\t" + telefonoNode.InnerText);
                    }

                    foreach (XmlElement emailNode in personaNode.GetElementsByTagName("email"))
                    {
                        listBox1.Items.Add("\t" + emailNode.InnerText);
                    }
                }

                if (!elementModified)
                {
                    MessageBox.Show("No se encontró el elemento seleccionado en el archivo XML.", "Modificar XML", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Elemento modificado correctamente. Recuerda guardar los cambios si quieres que se persistan.", "Modificar XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                xmlDoc.Save(xmlFilePath);
                MessageBox.Show("Archivo XML guardado correctamente.", "Guardar XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}