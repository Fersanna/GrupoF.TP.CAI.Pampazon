﻿namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    partial class BuscarPosicionForm
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
            InventarioBtn = new Button();
            SuspendLayout();
            // 
            // InventarioBtn
            // 
            InventarioBtn.Location = new Point(668, 378);
            InventarioBtn.Name = "InventarioBtn";
            InventarioBtn.Size = new Size(88, 23);
            InventarioBtn.TabIndex = 3;
            InventarioBtn.Text = "Inventario";
            InventarioBtn.UseVisualStyleBackColor = true;
            InventarioBtn.Click += InventarioBtn_Click;
            // 
            // BuscarPosicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InventarioBtn);
            Name = "BuscarPosicionForm";
            Text = "Buscar Posición";
            ResumeLayout(false);
        }

        #endregion

        private Button InventarioBtn;
    }
}