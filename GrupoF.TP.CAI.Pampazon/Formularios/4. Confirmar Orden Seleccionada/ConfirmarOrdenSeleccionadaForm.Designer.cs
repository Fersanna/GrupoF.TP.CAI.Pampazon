﻿namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    partial class ConfirmarOrdenSeleccionadaForm
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
            listView1 = new ListView();
            EliminarBtn = new Button();
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(61, 53);
            listView1.Name = "listView1";
            listView1.Size = new Size(659, 291);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(620, 359);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(98, 31);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(516, 359);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(98, 31);
            ConfirmarBtn.TabIndex = 2;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(412, 359);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(98, 31);
            CancelarBtn.TabIndex = 3;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ConfirmarOrdenSeleccionadaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(listView1);
            Name = "ConfirmarOrdenSeleccionadaForm";
            Text = "Confirmar Orden Seleccionada";
            Load += ConfirmarOrdenSeleccionadaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button EliminarBtn;
        private Button ConfirmarBtn;
        private Button CancelarBtn;
    }
}