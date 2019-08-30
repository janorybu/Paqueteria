namespace Win.Paqueteria
{
    partial class FormIngresos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresos));
            this.listaIngresosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaIngresosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Cancelar = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            precioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaIngresosBindingNavigator)).BeginInit();
            this.listaIngresosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaIngresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(25, 183);
            precioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 12;
            precioLabel.Text = "Precio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 84);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(25, 50);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(25, 117);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(25, 250);
            activoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 2;
            activoLabel.Text = "Activo:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(25, 216);
            codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 16;
            codigoLabel.Text = "Codigo:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(24, 152);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 23;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // listaIngresosBindingNavigator
            // 
            this.listaIngresosBindingNavigator.AddNewItem = null;
            this.listaIngresosBindingNavigator.BindingSource = this.listaIngresosBindingSource;
            this.listaIngresosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaIngresosBindingNavigator.DeleteItem = null;
            this.listaIngresosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaIngresosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaIngresosBindingNavigatorSaveItem,
            this.toolStripButton1Cancelar});
            this.listaIngresosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaIngresosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaIngresosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaIngresosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaIngresosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaIngresosBindingNavigator.Name = "listaIngresosBindingNavigator";
            this.listaIngresosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaIngresosBindingNavigator.Size = new System.Drawing.Size(747, 27);
            this.listaIngresosBindingNavigator.TabIndex = 0;
            this.listaIngresosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaIngresosBindingNavigatorSaveItem
            // 
            this.listaIngresosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaIngresosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaIngresosBindingNavigatorSaveItem.Image")));
            this.listaIngresosBindingNavigatorSaveItem.Name = "listaIngresosBindingNavigatorSaveItem";
            this.listaIngresosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaIngresosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaIngresosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaIngresosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1Cancelar
            // 
            this.toolStripButton1Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1Cancelar.Image")));
            this.toolStripButton1Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Cancelar.Name = "toolStripButton1Cancelar";
            this.toolStripButton1Cancelar.Size = new System.Drawing.Size(57, 24);
            this.toolStripButton1Cancelar.Text = "Cancelar";
            this.toolStripButton1Cancelar.Visible = false;
            this.toolStripButton1Cancelar.Click += new System.EventHandler(this.toolStripButton1Cancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.fotoPictureBox.Location = new System.Drawing.Point(356, 27);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(252, 191);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 21;
            this.fotoPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaIngresosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(94, 181);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(224, 20);
            this.precioTextBox.TabIndex = 13;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaIngresosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(94, 81);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(224, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaIngresosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(94, 47);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(224, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaIngresosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(94, 115);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(224, 20);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaIngresosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(94, 246);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(78, 20);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaIngresosBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(94, 214);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(224, 20);
            this.codigoTextBox.TabIndex = 17;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(356, 260);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(93, 23);
            this.Agregar.TabIndex = 19;
            this.Agregar.Text = "Agregar Foto";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCategoriasBindingSource, "Id", true));
            this.comboBox1.DataSource = this.listaCategoriasBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listaCategoriasBindingSource
            // 
            this.listaCategoriasBindingSource.DataSource = typeof(BL.Entregas.Categoria);
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 564);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaIngresosBindingNavigator);
            this.Name = "FormIngresos";
            this.Text = "Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.listaIngresosBindingNavigator)).EndInit();
            this.listaIngresosBindingNavigator.ResumeLayout(false);
            this.listaIngresosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaIngresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaIngresosBindingSource;
        private System.Windows.Forms.BindingNavigator listaIngresosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaIngresosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1Cancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaCategoriasBindingSource;
        private System.Windows.Forms.TextBox categoriaIdTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox1;
        private System.Windows.Forms.TextBox descripcionTextBox1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listaCategoriasBindingSource;
    }
}