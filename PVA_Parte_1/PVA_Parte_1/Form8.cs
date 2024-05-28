using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PVA_Parte_1.Class2;


namespace PVA_Parte_1
{
    internal partial class Form8 : Form
    {
        public Form8(Class2.vehículo vh)
        {
            InitializeComponent();
            MostrarDatosVehiculo(vh);
        }

        private void MostrarDatosVehiculo(Class2.vehículo vh)
        {
            label1.Text = vh.Marca;
            label2.Text = vh.Modelo;
            label3.Text = vh.Año.ToString();
            label4.Text = vh.Dni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}