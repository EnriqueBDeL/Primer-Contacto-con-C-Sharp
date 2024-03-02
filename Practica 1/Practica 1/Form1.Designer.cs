namespace Practica_1
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDirección = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficha Personal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(51, 160);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(155, 26);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxDirección
            // 
            this.textBoxDirección.Location = new System.Drawing.Point(47, 238);
            this.textBoxDirección.Name = "textBoxDirección";
            this.textBoxDirección.Size = new System.Drawing.Size(155, 26);
            this.textBoxDirección.TabIndex = 5;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(444, 143);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(103, 30);
            this.buttonInsertar.TabIndex = 7;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(665, 160);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(103, 30);
            this.buttonValidar.TabIndex = 8;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(665, 196);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 30);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(665, 238);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(103, 30);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(441, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Items.AddRange(new object[] {
            "Murcia",
            "Cartagena",
            "Totana"});
            this.comboBoxCiudad.Location = new System.Drawing.Point(247, 236);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(188, 28);
            this.comboBoxCiudad.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap|*.bmp|JPEG|*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.textBoxDirección);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDirección;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

