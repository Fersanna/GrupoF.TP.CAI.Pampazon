﻿using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    public partial class OrdenDeSeleccionForm : Form
    {
        public OrdenDeSeleccionModel model { get; set; }
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden de selección ha sido generada con éxito.");
        }

        public void CargarDatos(List<ListViewItem> items)
        {
            ListOrdenesSeleccionConfirmadas.Items.AddRange(items.ToArray());
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            foreach (OrdenDePreparacion ordenesSeleccionada in model.OrdenDePreparacion)
            {
                if (ordenesSeleccionada.EstadoOrden == "Seleccionada")
                {
                    ListViewItem item = new ListViewItem(ordenesSeleccionada.NumeroDeOrden);
                    item.SubItems.Add(ordenesSeleccionada.CodigoCliente);
                    item.SubItems.Add(ordenesSeleccionada.Fecha.ToString());
                    item.SubItems.Add(ordenesSeleccionada.CodigoTransportista);
                    item.SubItems.Add(ordenesSeleccionada.EstadoOrden);

                    ListOrdenesSeleccionConfirmadas.Items.Add(item);
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrioridadBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
