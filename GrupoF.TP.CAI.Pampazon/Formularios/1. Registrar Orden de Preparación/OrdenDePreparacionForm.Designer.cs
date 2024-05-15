﻿namespace GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación
{
    partial class OrdenDePreparacionForm
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
            EliminarBtn = new Button();
            CancelarBtn = new Button();
            label1 = new Label();
            ClienteNombreTextBox = new TextBox();
            TransportistaBox = new Label();
            FechaBox = new Label();
            CodigoClienteTextBox = new TextBox();
            label2 = new Label();
            TranspBox = new TextBox();
            ProductosOrdenList = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            ClienteBox = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(402, 339);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(100, 26);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Cancelar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(292, 339);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(100, 26);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Confirmar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 147);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Detalle de productos";
            // 
            // ClienteNombreTextBox
            // 
            ClienteNombreTextBox.Enabled = false;
            ClienteNombreTextBox.Location = new Point(392, 88);
            ClienteNombreTextBox.Margin = new Padding(3, 2, 3, 2);
            ClienteNombreTextBox.Name = "ClienteNombreTextBox";
            ClienteNombreTextBox.Size = new Size(110, 23);
            ClienteNombreTextBox.TabIndex = 4;
            ClienteNombreTextBox.TextChanged += ClienteNombreTextBox_TextChanged;
            // 
            // TransportistaBox
            // 
            TransportistaBox.AutoSize = true;
            TransportistaBox.Location = new Point(12, 41);
            TransportistaBox.Name = "TransportistaBox";
            TransportistaBox.Size = new Size(74, 15);
            TransportistaBox.TabIndex = 6;
            TransportistaBox.Text = "Transportista";
            // 
            // FechaBox
            // 
            FechaBox.AutoSize = true;
            FechaBox.Location = new Point(12, 88);
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(38, 15);
            FechaBox.TabIndex = 9;
            FechaBox.Text = "Fecha";
            // 
            // CodigoClienteTextBox
            // 
            CodigoClienteTextBox.Enabled = false;
            CodigoClienteTextBox.Location = new Point(392, 38);
            CodigoClienteTextBox.Margin = new Padding(3, 2, 3, 2);
            CodigoClienteTextBox.Name = "CodigoClienteTextBox";
            CodigoClienteTextBox.Size = new Size(110, 23);
            CodigoClienteTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 21);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // TranspBox
            // 
            TranspBox.Location = new Point(92, 38);
            TranspBox.Margin = new Padding(3, 2, 3, 2);
            TranspBox.Name = "TranspBox";
            TranspBox.Size = new Size(163, 23);
            TranspBox.TabIndex = 10;
            // 
            // ProductosOrdenList
            // 
            ProductosOrdenList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header });
            ProductosOrdenList.FullRowSelect = true;
            ProductosOrdenList.GridLines = true;
            ProductosOrdenList.Location = new Point(12, 165);
            ProductosOrdenList.Name = "ProductosOrdenList";
            ProductosOrdenList.Size = new Size(490, 169);
            ProductosOrdenList.TabIndex = 12;
            ProductosOrdenList.UseCompatibleStateImageBehavior = false;
            ProductosOrdenList.View = View.Details;
            ProductosOrdenList.SelectedIndexChanged += ProductosOrdenList_SelectedIndexChanged;
            // 
            // IdProducto_Header
            // 
            IdProducto_Header.Text = "Código Producto";
            IdProducto_Header.Width = 120;
            // 
            // Descripcion_Header
            // 
            Descripcion_Header.Text = "Descripción";
            Descripcion_Header.TextAlign = HorizontalAlignment.Center;
            Descripcion_Header.Width = 120;
            // 
            // Posicion_Header
            // 
            Posicion_Header.Text = "Posición";
            Posicion_Header.TextAlign = HorizontalAlignment.Center;
            Posicion_Header.Width = 120;
            // 
            // Cantidad_Header
            // 
            Cantidad_Header.Text = "Cantidad";
            Cantidad_Header.TextAlign = HorizontalAlignment.Center;
            Cantidad_Header.Width = 120;
            // 
            // ClienteBox
            // 
            ClienteBox.AutoSize = true;
            ClienteBox.Location = new Point(392, 71);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(44, 15);
            ClienteBox.TabIndex = 7;
            ClienteBox.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(56, 85);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // OrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 388);
            Controls.Add(dateTimePicker1);
            Controls.Add(ProductosOrdenList);
            Controls.Add(label2);
            Controls.Add(TranspBox);
            Controls.Add(FechaBox);
            Controls.Add(CodigoClienteTextBox);
            Controls.Add(ClienteBox);
            Controls.Add(TransportistaBox);
            Controls.Add(ClienteNombreTextBox);
            Controls.Add(label1);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Name = "OrdenDePreparacionForm";
            Text = "Orden de Preparacion";
            Load += OrdenDePreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EliminarBtn;
        private Button CancelarBtn;
        private Label label1;
        private TextBox ClienteNombreTextBox;
        private Label TransportistaBox;
        private Label FechaBox;
        private TextBox CodigoClienteTextBox;
        private Label label2;
        private TextBox TranspBox;
        private ListView ProductosOrdenList;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private Label ClienteBox;
        private DateTimePicker dateTimePicker1;
    }
}