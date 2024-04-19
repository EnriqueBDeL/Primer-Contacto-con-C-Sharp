using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Practica_6
{
    public partial class Form1 : Form
    {
        private XmlDocument xmlDoc;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                // Crear un OpenFileDialog para seleccionar el archivo XML
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
                openFileDialog.Title = "Seleccionar archivo XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xmlFilePath = openFileDialog.FileName;
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

                        XmlNodeList telefonos = personaNode.GetElementsByTagName("telefono");
                        foreach (XmlElement telefonoNode in telefonos)
                        {
                            listBox1.Items.Add("\t" + telefonoNode.InnerText);
                        }

                        XmlNodeList emails = personaNode.GetElementsByTagName("email");
                        foreach (XmlElement emailNode in emails)
                        {
                            listBox1.Items.Add("\t" + emailNode.InnerText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar el documento XML después de cargar
                xmlDoc = null; // Liberar la referencia al documento XML
            }
        }

        private string GetNodeInnerText(XmlElement parentNode, string nodeName)
        {
            XmlNodeList nodeList = parentNode.GetElementsByTagName(nodeName);
            if (nodeList.Count > 0)
            {
                return nodeList[0].InnerText;
            }
            return string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Obtener el texto completo del elemento seleccionado en el ListBox
                string selectedText = listBox1.SelectedItem.ToString();

                // Buscar el índice de la primera tabulación en el texto
                int tabIndex = selectedText.IndexOf('\t');

                if (tabIndex != -1 && tabIndex < selectedText.Length - 1)
                {
                    // Extraer el apellido, que está después de la primera tabulación
                    string apellidoSeleccionado = selectedText.Substring(tabIndex + 1).Trim();

                    try
                    {
                        // Ruta del archivo XML (puedes cambiar la ruta según sea necesario)
                        string xmlFilePath = @"C:\Users\enriq\Downloads\ejemplo_2.xml";
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(xmlFilePath);

                        // Obtener la lista de nodos <persona> del archivo XML
                        XmlNodeList personas = xmlDoc.SelectNodes("//persona");

                        foreach (XmlNode personaNode in personas)
                        {
                            XmlNode apellido1Node = personaNode.SelectSingleNode("apellido1");

                            if (apellido1Node != null && apellido1Node.InnerText.Equals(apellidoSeleccionado, StringComparison.OrdinalIgnoreCase))
                            {
                                // Modificar el apellido1 en el XML con el texto del TextBox
                                apellido1Node.InnerText = textBox1.Text;
                            }
                        }

                        // Guardar los cambios en el archivo XML
                        xmlDoc.Save(xmlFilePath);

                        // Limpiar el ListBox y volver a cargar los datos actualizados
                        listBox1.Items.Clear();
                        button1_Click(sender, e); // Recargar los datos en el ListBox
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El formato del elemento seleccionado en el ListBox no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento del ListBox para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo XML (puedes cambiar la ruta según sea necesario)
                string xmlFilePath = @"C:\Users\enriq\Downloads\ejemplo_2.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // Obtener la lista de nodos <persona> del archivo XML
                XmlNodeList personas = xmlDoc.SelectNodes("//persona");

                foreach (XmlNode personaNode in personas)
                {
                    XmlNode apellido1Node = personaNode.SelectSingleNode("apellido1");

                    if (apellido1Node != null)
                    {
                        // Modificar el apellido1 en el XML con el texto del TextBox
                        apellido1Node.InnerText = textBox1.Text;
                    }
                }

                // Guardar los cambios en el archivo XML
                xmlDoc.Save(xmlFilePath);

                MessageBox.Show("Archivo XML guardado correctamente.", "Guardar XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar el documento XML después de guardar
                xmlDoc = null; // Liberar la referencia al documento XML
            }
        }
    }
}