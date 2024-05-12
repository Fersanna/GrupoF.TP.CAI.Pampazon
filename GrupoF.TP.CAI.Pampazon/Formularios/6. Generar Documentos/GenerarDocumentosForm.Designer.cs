﻿namespace GrupoF.TP.CAI.Pampazon
{
    partial class GenerarDocumentosForm
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
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "E-000001", "01", "13/05/24", "Express Cargo" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "E-000002", "02", "13/05/24", "Logística Global" }, -1);
            GenerarBtn = new Button();
            CancelarBtn = new Button();
            listView2 = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(388, 304);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(91, 23);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(485, 304);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(91, 23);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum });
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView2.Location = new Point(40, 64);
            listView2.Name = "listView2";
            listView2.Size = new Size(536, 234);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "ID";
            NumeroColum.Width = 130;
            // 
            // ClienteColum
            // 
            ClienteColum.Text = "Cliente";
            ClienteColum.TextAlign = HorizontalAlignment.Center;
            ClienteColum.Width = 130;
            // 
            // FechaColum
            // 
            FechaColum.Text = "Fecha";
            FechaColum.TextAlign = HorizontalAlignment.Center;
            FechaColum.Width = 130;
            // 
            // TranspColum
            // 
            TranspColum.Text = "Transportista";
            TranspColum.TextAlign = HorizontalAlignment.Center;
            TranspColum.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 8;
            label1.Text = "Listado de ordenes de entrega";
            // 
            // GenerarDocumentosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 384);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarBtn);
            Name = "GenerarDocumentosForm";
            Text = "Generar Documentos";
            Load += GenerarDocumentosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button GenerarBtn;
        private Button CancelarBtn;
        private ListView listView2;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private Label label1;
    }
}