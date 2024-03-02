namespace Practica_4__Intento_2_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbDocumento = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbDocumento
            // 
            this.txbDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDocumento.Location = new System.Drawing.Point(0, 0);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(800, 241);
            this.txbDocumento.TabIndex = 0;
            this.txbDocumento.Text = "";
            this.txbDocumento.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.txbDocumento);
            this.Name = "Form2";
            this.Text = "Fichero";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txbDocumento;
    }
}