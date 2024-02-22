namespace Practica_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbhijo = new System.Windows.Forms.RadioButton();
            this.rbrama = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.txtinsertar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tvarbol = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbchica = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbchico = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.txttlfno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnborrarlista = new System.Windows.Forms.Button();
            this.btinsertarlista = new System.Windows.Forms.Button();
            this.lvwlista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonsalir = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtinsertar);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.tvarbol);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arbol";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbhijo);
            this.groupBox1.Controls.Add(this.rbrama);
            this.groupBox1.Location = new System.Drawing.Point(30, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbhijo
            // 
            this.rbhijo.AutoSize = true;
            this.rbhijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbhijo.ImageIndex = 0;
            this.rbhijo.ImageList = this.imageList2;
            this.rbhijo.Location = new System.Drawing.Point(182, 41);
            this.rbhijo.Name = "rbhijo";
            this.rbhijo.Size = new System.Drawing.Size(61, 24);
            this.rbhijo.TabIndex = 6;
            this.rbhijo.TabStop = true;
            this.rbhijo.Text = "Hijo";
            this.rbhijo.UseVisualStyleBackColor = true;
            this.rbhijo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbrama
            // 
            this.rbrama.AutoSize = true;
            this.rbrama.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbrama.ImageIndex = 1;
            this.rbrama.ImageList = this.imageList2;
            this.rbrama.Location = new System.Drawing.Point(52, 41);
            this.rbrama.Name = "rbrama";
            this.rbrama.Size = new System.Drawing.Size(77, 24);
            this.rbrama.TabIndex = 5;
            this.rbrama.TabStop = true;
            this.rbrama.Text = "Rama";
            this.rbrama.UseVisualStyleBackColor = true;
            this.rbrama.CheckedChanged += new System.EventHandler(this.rbrama_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Insertar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtinsertar
            // 
            this.txtinsertar.Location = new System.Drawing.Point(31, 352);
            this.txtinsertar.Name = "txtinsertar";
            this.txtinsertar.Size = new System.Drawing.Size(300, 26);
            this.txtinsertar.TabIndex = 3;
            this.txtinsertar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Borrar todo el arbol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tvarbol
            // 
            this.tvarbol.Location = new System.Drawing.Point(30, 32);
            this.tvarbol.Name = "tvarbol";
            this.tvarbol.Size = new System.Drawing.Size(474, 290);
            this.tvarbol.TabIndex = 0;
            this.tvarbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvarbol_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.DNI);
            this.tabPage2.Controls.Add(this.txttlfno);
            this.tabPage2.Controls.Add(this.txtnombre);
            this.tabPage2.Controls.Add(this.txtdni);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.btnborrarlista);
            this.tabPage2.Controls.Add(this.btinsertarlista);
            this.tabPage2.Controls.Add(this.lvwlista);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbchica);
            this.groupBox2.Controls.Add(this.rbchico);
            this.groupBox2.Location = new System.Drawing.Point(346, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 168);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icono";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbchica
            // 
            this.rbchica.AutoSize = true;
            this.rbchica.ImageIndex = 1;
            this.rbchica.ImageList = this.imageList1;
            this.rbchica.Location = new System.Drawing.Point(20, 118);
            this.rbchica.Name = "rbchica";
            this.rbchica.Size = new System.Drawing.Size(37, 20);
            this.rbchica.TabIndex = 1;
            this.rbchica.TabStop = true;
            this.rbchica.UseVisualStyleBackColor = true;
            this.rbchica.CheckedChanged += new System.EventHandler(this.rbc_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "145867.png");
            this.imageList1.Images.SetKeyName(1, "7683451.png");
            // 
            // rbchico
            // 
            this.rbchico.AutoSize = true;
            this.rbchico.ImageIndex = 0;
            this.rbchico.ImageList = this.imageList1;
            this.rbchico.Location = new System.Drawing.Point(20, 62);
            this.rbchico.Name = "rbchico";
            this.rbchico.Size = new System.Drawing.Size(37, 20);
            this.rbchico.TabIndex = 0;
            this.rbchico.TabStop = true;
            this.rbchico.UseVisualStyleBackColor = true;
            this.rbchico.CheckedChanged += new System.EventHandler(this.rbchico_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(35, 347);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(37, 20);
            this.DNI.TabIndex = 7;
            this.DNI.Text = "DNI";
            this.DNI.Click += new System.EventHandler(this.DNI_Click);
            // 
            // txttlfno
            // 
            this.txttlfno.Location = new System.Drawing.Point(88, 429);
            this.txttlfno.Name = "txttlfno";
            this.txttlfno.Size = new System.Drawing.Size(245, 26);
            this.txttlfno.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(88, 385);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(246, 26);
            this.txtnombre.TabIndex = 5;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(87, 345);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(247, 26);
            this.txtdni.TabIndex = 4;
            this.txtdni.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "Borrar Todo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnborrarlista
            // 
            this.btnborrarlista.Location = new System.Drawing.Point(27, 492);
            this.btnborrarlista.Name = "btnborrarlista";
            this.btnborrarlista.Size = new System.Drawing.Size(182, 40);
            this.btnborrarlista.TabIndex = 2;
            this.btnborrarlista.Text = "Borrar";
            this.btnborrarlista.UseVisualStyleBackColor = true;
            this.btnborrarlista.Click += new System.EventHandler(this.btnborrarlista_Click);
            // 
            // btinsertarlista
            // 
            this.btinsertarlista.Location = new System.Drawing.Point(366, 272);
            this.btinsertarlista.Name = "btinsertarlista";
            this.btinsertarlista.Size = new System.Drawing.Size(145, 45);
            this.btinsertarlista.TabIndex = 1;
            this.btinsertarlista.Text = "Insertar";
            this.btinsertarlista.UseVisualStyleBackColor = true;
            this.btinsertarlista.Click += new System.EventHandler(this.btinsertarlista_Click);
            // 
            // lvwlista
            // 
            this.lvwlista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwlista.HideSelection = false;
            this.lvwlista.Location = new System.Drawing.Point(23, 24);
            this.lvwlista.Name = "lvwlista";
            this.lvwlista.Size = new System.Drawing.Size(489, 229);
            this.lvwlista.SmallImageList = this.imageList1;
            this.lvwlista.TabIndex = 0;
            this.lvwlista.UseCompatibleStateImageBehavior = false;
            this.lvwlista.View = System.Windows.Forms.View.Details;
            this.lvwlista.SelectedIndexChanged += new System.EventHandler(this.lvwlista_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Teléfono";
            // 
            // buttonsalir
            // 
            this.buttonsalir.Location = new System.Drawing.Point(375, 639);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(200, 53);
            this.buttonsalir.TabIndex = 0;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "descarga.png");
            this.imageList2.Images.SetKeyName(1, "images.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 727);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.TreeView tvarbol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtinsertar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbrama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbhijo;
        private System.Windows.Forms.ListView lvwlista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.TextBox txttlfno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnborrarlista;
        private System.Windows.Forms.Button btinsertarlista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbchica;
        private System.Windows.Forms.RadioButton rbchico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

