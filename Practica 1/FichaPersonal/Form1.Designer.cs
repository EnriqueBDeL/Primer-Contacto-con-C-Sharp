namespace FichaPersonal
{
    partial class FICHA_PERSONAL
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbciudad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picfoto = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsobre = new System.Windows.Forms.Button();
            this.Idiomas = new System.Windows.Forms.GroupBox();
            this.Idiomasselct = new System.Windows.Forms.CheckedListBox();
            this.insertidioma = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.Idiomas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(67, 122);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Tag = "";
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(71, 218);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(274, 26);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(71, 145);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(274, 26);
            this.txtnombre.TabIndex = 7;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // cbciudad
            // 
            this.cbciudad.FormattingEnabled = true;
            this.cbciudad.Items.AddRange(new object[] {
            "Murcia",
            "Valencia ",
            "Madrid",
            "Barcelona"});
            this.cbciudad.Location = new System.Drawing.Point(71, 287);
            this.cbciudad.Name = "cbciudad";
            this.cbciudad.Size = new System.Drawing.Size(274, 28);
            this.cbciudad.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(403, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.Form1_Load);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Validar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // picfoto
            // 
            this.picfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picfoto.Location = new System.Drawing.Point(403, 122);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(124, 116);
            this.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfoto.TabIndex = 13;
            this.picfoto.TabStop = false;
            this.picfoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "Insertar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            this.ofdfoto.Filter = "Bitmap|*.bmp|JPEG|*.jpg";
            this.ofdfoto.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "FICHA PERSONAL";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonsobre
            // 
            this.buttonsobre.Location = new System.Drawing.Point(403, 408);
            this.buttonsobre.Name = "buttonsobre";
            this.buttonsobre.Size = new System.Drawing.Size(107, 31);
            this.buttonsobre.TabIndex = 17;
            this.buttonsobre.Text = "Sobre";
            this.buttonsobre.UseVisualStyleBackColor = true;
            this.buttonsobre.Click += new System.EventHandler(this.buttonsobre_Click);
            // 
            // Idiomas
            // 
            this.Idiomas.Controls.Add(this.Idiomasselct);
            this.Idiomas.Controls.Add(this.insertidioma);
            this.Idiomas.Controls.Add(this.button7);
            this.Idiomas.Controls.Add(this.button6);
            this.Idiomas.Controls.Add(this.button5);
            this.Idiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idiomas.Location = new System.Drawing.Point(60, 349);
            this.Idiomas.Name = "Idiomas";
            this.Idiomas.Size = new System.Drawing.Size(299, 317);
            this.Idiomas.TabIndex = 18;
            this.Idiomas.TabStop = false;
            this.Idiomas.Text = "Idiomas";
            this.Idiomas.Enter += new System.EventHandler(this.Idiomas_Enter);
            // 
            // Idiomasselct
            // 
            this.Idiomasselct.FormattingEnabled = true;
            this.Idiomasselct.Location = new System.Drawing.Point(11, 41);
            this.Idiomasselct.Name = "Idiomasselct";
            this.Idiomasselct.Size = new System.Drawing.Size(282, 166);
            this.Idiomasselct.TabIndex = 20;
            this.Idiomasselct.SelectedIndexChanged += new System.EventHandler(this.Idiomasselct_SelectedIndexChanged);
            // 
            // insertidioma
            // 
            this.insertidioma.Location = new System.Drawing.Point(103, 234);
            this.insertidioma.Name = "insertidioma";
            this.insertidioma.Size = new System.Drawing.Size(182, 30);
            this.insertidioma.TabIndex = 19;
            this.insertidioma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.insertidioma.Enter += new System.EventHandler(this.textBox1_TextChanged);
            this.insertidioma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.insertidioma_KeyDown);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(103, 267);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 35);
            this.button7.TabIndex = 2;
            this.button7.Text = "Borrar la lista";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 35);
            this.button6.TabIndex = 1;
            this.button6.Text = "Añadir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Idiomasselct_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "Borrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FICHA_PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(663, 677);
            this.Controls.Add(this.Idiomas);
            this.Controls.Add(this.buttonsobre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.picfoto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbciudad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombre);
            this.Name = "FICHA_PERSONAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).EndInit();
            this.Idiomas.ResumeLayout(false);
            this.Idiomas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbciudad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox picfoto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsobre;
        private System.Windows.Forms.GroupBox Idiomas;
        private System.Windows.Forms.TextBox insertidioma;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox Idiomasselct;
    }
}

