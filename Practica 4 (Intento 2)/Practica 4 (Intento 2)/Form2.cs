﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4__Intento_2_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void SetContenido(string contenido)
        {
            textBox.Text = contenido;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
        }
    }
}
