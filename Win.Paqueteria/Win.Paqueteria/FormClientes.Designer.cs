﻿namespace Win.Paqueteria
{
    partial class FormClientes
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
            System.Windows.Forms.Label correoLabel1;
            System.Windows.Forms.Label direccionLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label telefonoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.clientesBLBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clientesBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.clientesBLBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoTextBox1 = new System.Windows.Forms.TextBox();
            this.direccionTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.telefonoTextBox1 = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            correoLabel1 = new System.Windows.Forms.Label();
            direccionLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            telefonoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBLBindingNavigator)).BeginInit();
            this.clientesBLBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // correoLabel1
            // 
            correoLabel1.AutoSize = true;
            correoLabel1.Location = new System.Drawing.Point(32, 202);
            correoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            correoLabel1.Name = "correoLabel1";
            correoLabel1.Size = new System.Drawing.Size(41, 13);
            correoLabel1.TabIndex = 11;
            correoLabel1.Text = "Correo:";
            // 
            // direccionLabel1
            // 
            direccionLabel1.AutoSize = true;
            direccionLabel1.Location = new System.Drawing.Point(32, 133);
            direccionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            direccionLabel1.Name = "direccionLabel1";
            direccionLabel1.Size = new System.Drawing.Size(55, 13);
            direccionLabel1.TabIndex = 13;
            direccionLabel1.Text = "Direccion:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(32, 64);
            idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 15;
            idLabel1.Text = "Id:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(32, 101);
            nombreLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 17;
            nombreLabel1.Text = "Nombre:";
            // 
            // telefonoLabel1
            // 
            telefonoLabel1.AutoSize = true;
            telefonoLabel1.Location = new System.Drawing.Point(32, 167);
            telefonoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefonoLabel1.Name = "telefonoLabel1";
            telefonoLabel1.Size = new System.Drawing.Size(52, 13);
            telefonoLabel1.TabIndex = 19;
            telefonoLabel1.Text = "Telefono:";
            // 
            // clientesBLBindingNavigator
            // 
            this.clientesBLBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientesBLBindingNavigator.BindingSource = this.clientesBLBindingSource;
            this.clientesBLBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBLBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientesBLBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientesBLBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientesBLBindingNavigatorSaveItem,
            this.Cancelar});
            this.clientesBLBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBLBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBLBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBLBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBLBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBLBindingNavigator.Name = "clientesBLBindingNavigator";
            this.clientesBLBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBLBindingNavigator.Size = new System.Drawing.Size(634, 27);
            this.clientesBLBindingNavigator.TabIndex = 0;
            this.clientesBLBindingNavigator.Text = "bindingNavigator1";
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
            // clientesBLBindingSource
            // 
            this.clientesBLBindingSource.DataSource = typeof(BL.Entregas.ClientesBL);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // clientesBLBindingNavigatorSaveItem
            // 
            this.clientesBLBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBLBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBLBindingNavigatorSaveItem.Image")));
            this.clientesBLBindingNavigatorSaveItem.Name = "clientesBLBindingNavigatorSaveItem";
            this.clientesBLBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.clientesBLBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(BL.Entregas.Usuario);
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataMember = "ListaClientes";
            this.listaClientesBindingSource.DataSource = this.clientesBLBindingSource;
            // 
            // correoTextBox1
            // 
            this.correoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Correo", true));
            this.correoTextBox1.Location = new System.Drawing.Point(90, 199);
            this.correoTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.correoTextBox1.Name = "correoTextBox1";
            this.correoTextBox1.Size = new System.Drawing.Size(296, 20);
            this.correoTextBox1.TabIndex = 12;
            // 
            // direccionTextBox1
            // 
            this.direccionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Direccion", true));
            this.direccionTextBox1.Location = new System.Drawing.Point(90, 131);
            this.direccionTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.direccionTextBox1.Name = "direccionTextBox1";
            this.direccionTextBox1.Size = new System.Drawing.Size(296, 20);
            this.direccionTextBox1.TabIndex = 14;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(90, 62);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(296, 20);
            this.idTextBox1.TabIndex = 16;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Nombre", true));
            this.nombreTextBox1.Location = new System.Drawing.Point(90, 98);
            this.nombreTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(296, 20);
            this.nombreTextBox1.TabIndex = 18;
            // 
            // telefonoTextBox1
            // 
            this.telefonoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "Telefono", true));
            this.telefonoTextBox1.Location = new System.Drawing.Point(90, 164);
            this.telefonoTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoTextBox1.Name = "telefonoTextBox1";
            this.telefonoTextBox1.Size = new System.Drawing.Size(296, 20);
            this.telefonoTextBox1.TabIndex = 20;
            // 
            // Cancelar
            // 
            this.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(57, 24);
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 510);
            this.Controls.Add(correoLabel1);
            this.Controls.Add(this.correoTextBox1);
            this.Controls.Add(direccionLabel1);
            this.Controls.Add(this.direccionTextBox1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.nombreTextBox1);
            this.Controls.Add(telefonoLabel1);
            this.Controls.Add(this.telefonoTextBox1);
            this.Controls.Add(this.clientesBLBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clientesBLBindingNavigator)).EndInit();
            this.clientesBLBindingNavigator.ResumeLayout(false);
            this.clientesBLBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientesBLBindingSource;
        private System.Windows.Forms.BindingNavigator clientesBLBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientesBLBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.TextBox correoTextBox1;
        private System.Windows.Forms.TextBox direccionTextBox1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox telefonoTextBox1;
        private System.Windows.Forms.ToolStripButton Cancelar;
    }
}