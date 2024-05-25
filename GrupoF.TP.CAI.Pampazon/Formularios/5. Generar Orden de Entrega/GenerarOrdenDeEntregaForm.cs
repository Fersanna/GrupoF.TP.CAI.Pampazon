﻿using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección;
using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class GenerarOrdenDeEntregaForm : Form
    {
        OrdenDeEntregaModel model;
        public GenerarOrdenDeEntregaForm()
        {
            InitializeComponent();
            model = new OrdenDeEntregaModel();
        }

        private void GenerarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            CargarOrdenesSeleccionadas();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {

        }

        private void CargarOrdenesSeleccionadas()
        {
            listOrdenesPreparacion.Items.Clear();

            foreach (OrdenDePreparacion ordenes in model.OrdenesSeleccionadas)
            {
                ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                item.SubItems.Add(ordenes.CodigoCliente);
                item.SubItems.Add(ordenes.Fecha.ToString());
                item.SubItems.Add(ordenes.CodigoTransportista);
                item.SubItems.Add(ordenes.EstadoOrden);

                listOrdenesPreparacion.Items.Add(item);

                item.Tag = ordenes;
            }

        }

        private void listOrdenesPreparacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOrdenesPreparacion.SelectedItems.Count > 0)
            {
                OrdenDePreparacion ordenSeleccionada = (OrdenDePreparacion)listOrdenesPreparacion.SelectedItems[0].Tag as OrdenDePreparacion;


                var error = model.ValidarOrden(ordenSeleccionada);

                if (error != null)
                {
                    MessageBox.Show(error);
                    CargarOrdenesSeleccionadas();
                    return;
                }

                ordenSeleccionada.EstadoOrden = "En selección";

                CargarOrdenesSeleccionadas();
            }
            MessageBox.Show("La orden fue seleccionada");
        }



        private void ActualizarListaOrdenesFiltradas(List<OrdenDePreparacion> ordenesFiltradas)
        {
            listOrdenesPreparacion.Items.Clear();

            foreach (var orden in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem(orden.NumeroDeOrden);
                item.SubItems.Add(orden.CodigoCliente);
                item.SubItems.Add(orden.Fecha.ToString());
                item.SubItems.Add(orden.CodigoTransportista);
                item.SubItems.Add(orden.EstadoOrden);

                listOrdenesPreparacion.Items.Add(item);
            }
        }

        private void FiltrarBtn_Click_1(object sender, EventArgs e)
        {
            model.Cliente = ClienteTextBox.Text;
            model.FechaDesde = DesdeTimePicker.Value;
            model.FechaHasta = HastadateTimePicker.Value;
            model.Transportista = TransportistaTextBox.Text;
            model.NumeroOrden = NumeroOrdenTextBox.Text;


            var error = model.ValidarFiltro();

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            var ordenesFiltradas = model.FiltrarOrdenes();

            if (ordenesFiltradas == null)
            {
                return;
            }


            ActualizarListaOrdenesFiltradas(ordenesFiltradas);
        }
    }
}
