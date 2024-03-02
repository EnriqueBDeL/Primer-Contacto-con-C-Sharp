namespace Práctica_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.textAPELLIDO1 = new System.Windows.Forms.TextBox();
            this.textAPELLIDO2 = new System.Windows.Forms.TextBox();
            this.textEDAD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(34, 109);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(368, 26);
            this.textDNI.TabIndex = 5;
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(34, 186);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(368, 26);
            this.textNOMBRE.TabIndex = 6;
            // 
            // textAPELLIDO1
            // 
            this.textAPELLIDO1.Location = new System.Drawing.Point(34, 246);
            this.textAPELLIDO1.Name = "textAPELLIDO1";
            this.textAPELLIDO1.Size = new System.Drawing.Size(368, 26);
            this.textAPELLIDO1.TabIndex = 7;
            // 
            // textAPELLIDO2
            // 
            this.textAPELLIDO2.Location = new System.Drawing.Point(34, 309);
            this.textAPELLIDO2.Name = "textAPELLIDO2";
            this.textAPELLIDO2.Size = new System.Drawing.Size(368, 26);
            this.textAPELLIDO2.TabIndex = 8;
            // 
            // textEDAD
            // 
            this.textEDAD.Location = new System.Drawing.Point(34, 369);
            this.textEDAD.Name = "textEDAD";
            this.textEDAD.Size = new System.Drawing.Size(368, 26);
            this.textEDAD.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 62);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mostrar datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 852);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 62);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sumar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 715);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Suma";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(34, 762);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 26);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 765);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "+";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(159, 760);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(74, 26);
            this.textBox7.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dni,
            this.Nombre,
            this.Apellido1,
            this.Apellido2,
            this.Edad});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(448, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1052, 556);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Dni
            // 
            this.Dni.Text = "DNI";
            this.Dni.Width = 112;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 112;
            // 
            // Apellido1
            // 
            this.Apellido1.Text = "Apellido 1";
            this.Apellido1.Width = 112;
            // 
            // Apellido2
            // 
            this.Apellido2.Text = "Apellido 2";
            this.Apellido2.Width = 112;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 112;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(448, 683);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(368, 62);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(838, 683);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(368, 62);
            this.button5.TabIndex = 19;
            this.button5.Text = "Mantenimiento";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1120, 852);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(368, 62);
            this.button6.TabIndex = 20;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 946);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEDAD);
            this.Controls.Add(this.textAPELLIDO2);
            this.Controls.Add(this.textAPELLIDO1);
            this.Controls.Add(this.textNOMBRE);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.TextBox textAPELLIDO1;
        private System.Windows.Forms.TextBox textAPELLIDO2;
        private System.Windows.Forms.TextBox textEDAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.ColumnHeader Dni;
        public System.Windows.Forms.ColumnHeader Nombre;
        public System.Windows.Forms.ColumnHeader Apellido1;
        public System.Windows.Forms.ColumnHeader Apellido2;
        public System.Windows.Forms.ColumnHeader Edad;
        public System.Windows.Forms.ListView listView1;
    }
}

