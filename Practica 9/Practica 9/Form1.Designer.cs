namespace Practica_9
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
            System.Windows.Forms.Label espLabel;
            System.Windows.Forms.Label ingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.traduccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.traduccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.espTextBox = new System.Windows.Forms.TextBox();
            this.ingTextBox = new System.Windows.Forms.TextBox();
            this.traduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvadsdiccionario = new Practica_9.pvadsdiccionario();
            this.traduccionTableAdapter = new Practica_9.pvadsdiccionarioTableAdapters.traduccionTableAdapter();
            this.tableAdapterManager = new Practica_9.pvadsdiccionarioTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.espDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbling = new System.Windows.Forms.Label();
            espLabel = new System.Windows.Forms.Label();
            ingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.traduccionBindingNavigator)).BeginInit();
            this.traduccionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traduccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvadsdiccionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // espLabel
            // 
            espLabel.AutoSize = true;
            espLabel.Location = new System.Drawing.Point(41, 111);
            espLabel.Name = "espLabel";
            espLabel.Size = new System.Drawing.Size(33, 16);
            espLabel.TabIndex = 1;
            espLabel.Text = "esp:";
            // 
            // ingLabel
            // 
            ingLabel.AutoSize = true;
            ingLabel.Location = new System.Drawing.Point(41, 139);
            ingLabel.Name = "ingLabel";
            ingLabel.Size = new System.Drawing.Size(28, 16);
            ingLabel.TabIndex = 3;
            ingLabel.Text = "ing:";
            // 
            // traduccionBindingNavigator
            // 
            this.traduccionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.traduccionBindingNavigator.BindingSource = this.traduccionBindingSource;
            this.traduccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.traduccionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.traduccionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.traduccionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.traduccionBindingNavigatorSaveItem});
            this.traduccionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.traduccionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.traduccionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.traduccionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.traduccionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.traduccionBindingNavigator.Name = "traduccionBindingNavigator";
            this.traduccionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.traduccionBindingNavigator.Size = new System.Drawing.Size(605, 27);
            this.traduccionBindingNavigator.TabIndex = 0;
            this.traduccionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // traduccionBindingNavigatorSaveItem
            // 
            this.traduccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.traduccionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("traduccionBindingNavigatorSaveItem.Image")));
            this.traduccionBindingNavigatorSaveItem.Name = "traduccionBindingNavigatorSaveItem";
            this.traduccionBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.traduccionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.traduccionBindingNavigatorSaveItem.Click += new System.EventHandler(this.traduccionBindingNavigatorSaveItem_Click_2);
            // 
            // espTextBox
            // 
            this.espTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traduccionBindingSource, "esp", true));
            this.espTextBox.Location = new System.Drawing.Point(80, 108);
            this.espTextBox.Name = "espTextBox";
            this.espTextBox.Size = new System.Drawing.Size(100, 22);
            this.espTextBox.TabIndex = 2;
            this.espTextBox.TextChanged += new System.EventHandler(this.espTextBox_TextChanged);
            this.espTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.espTextBox_Validating);
            // 
            // ingTextBox
            // 
            this.ingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traduccionBindingSource, "ing", true));
            this.ingTextBox.Location = new System.Drawing.Point(80, 136);
            this.ingTextBox.Name = "ingTextBox";
            this.ingTextBox.Size = new System.Drawing.Size(100, 22);
            this.ingTextBox.TabIndex = 4;
            // 
            // traduccionBindingSource
            // 
            this.traduccionBindingSource.DataMember = "traduccion";
            this.traduccionBindingSource.DataSource = this.pvadsdiccionario;
            // 
            // pvadsdiccionario
            // 
            this.pvadsdiccionario.DataSetName = "pvadsdiccionario";
            this.pvadsdiccionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traduccionTableAdapter
            // 
            this.traduccionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.traduccionTableAdapter = this.traduccionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Practica_9.pvadsdiccionarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.espDataGridViewTextBoxColumn,
            this.ingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traduccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(234, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(302, 325);
            this.dataGridView1.TabIndex = 5;
            // 
            // espDataGridViewTextBoxColumn
            // 
            this.espDataGridViewTextBoxColumn.DataPropertyName = "esp";
            this.espDataGridViewTextBoxColumn.HeaderText = "esp";
            this.espDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.espDataGridViewTextBoxColumn.Name = "espDataGridViewTextBoxColumn";
            this.espDataGridViewTextBoxColumn.ReadOnly = true;
            this.espDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingDataGridViewTextBoxColumn
            // 
            this.ingDataGridViewTextBoxColumn.DataPropertyName = "ing";
            this.ingDataGridViewTextBoxColumn.HeaderText = "ing";
            this.ingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingDataGridViewTextBoxColumn.Name = "ingDataGridViewTextBoxColumn";
            this.ingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Búsqueda(español)";
            // 
            // lbling
            // 
            this.lbling.AutoSize = true;
            this.lbling.Location = new System.Drawing.Point(340, 74);
            this.lbling.Name = "lbling";
            this.lbling.Size = new System.Drawing.Size(77, 16);
            this.lbling.TabIndex = 9;
            this.lbling.Text = "(traducción)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.lbling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(espLabel);
            this.Controls.Add(this.espTextBox);
            this.Controls.Add(ingLabel);
            this.Controls.Add(this.ingTextBox);
            this.Controls.Add(this.traduccionBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traduccionBindingNavigator)).EndInit();
            this.traduccionBindingNavigator.ResumeLayout(false);
            this.traduccionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traduccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvadsdiccionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pvadsdiccionario pvadsdiccionario;
        private System.Windows.Forms.BindingSource traduccionBindingSource;
        private pvadsdiccionarioTableAdapters.traduccionTableAdapter traduccionTableAdapter;
        private pvadsdiccionarioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator traduccionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton traduccionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox espTextBox;
        private System.Windows.Forms.TextBox ingTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn espDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbling;
    }
}

