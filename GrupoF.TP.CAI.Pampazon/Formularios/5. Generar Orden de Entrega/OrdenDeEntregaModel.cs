﻿using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    internal class OrdenDeEntregaModel
    {


        public string Cliente { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public string Transportista { get; set; }

        public string NumeroOrden { get; set; }

        public List<OrdenDePreparacion> OrdenesConfirmadas { get; set; }
        public List<OrdenDePreparacion> OrdenesSeleccionadas { get; set; } = new List<OrdenDePreparacion> {
          new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000001",
                CodigoCliente = "Moron Construcciones",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 1",
                EstadoOrden = "Seleccionada"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000002",
                CodigoCliente = "Fortin SRL",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 2",
                EstadoOrden = "Seleccionada"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000003",
                CodigoCliente = "Valentin Gomez S.A",
                Fecha = new DateTime(2024, 5, 14),
                CodigoTransportista = "Transportista 3",
                EstadoOrden = "Seleccionada"
            },

            };

        internal List<OrdenDePreparacion> FiltrarOrdenes()
        {
            var OrdenesFiltradas = OrdenesSeleccionadas.Where
                   (p => p.Fecha >= FechaDesde && p.Fecha <= FechaHasta &&
                    (string.IsNullOrEmpty(Cliente) || p.CodigoCliente.Contains(Cliente, StringComparison.OrdinalIgnoreCase) || p.CodigoTransportista.Contains(Transportista, StringComparison.OrdinalIgnoreCase) || p.NumeroDeOrden.Contains(NumeroOrden, StringComparison.OrdinalIgnoreCase)))
                 .ToList();
            if (!OrdenesFiltradas.Any())
            {
                MessageBox.Show("No existen Ordenes con esas carcartesticas para el rango de fecha indicado");
                return null;
            }


            return OrdenesFiltradas;
        }


        internal string ValidarFiltro()
        {
            if (string.IsNullOrWhiteSpace(Cliente))
            {
                return "El nombre del cliente no puede estar vacío.";
            }
            if (Cliente.Length > 30)
            {
                return "El nombre del cliente no puede tener más de 30 caracteres.";
            }


            if (string.IsNullOrWhiteSpace(Transportista))
            {
                return "El nombre del Transportista no puede estar vacío.";
            }

            if (string.IsNullOrWhiteSpace(NumeroOrden))
            {
                return "El numero de orden no puede estar vacío.";
            }

            return null;
        }

        internal string ValidarOrden(OrdenDePreparacion ordenSeleccionada)
        {   // Arreglar esto para cuando se null
            if (ordenSeleccionada.EstadoOrden == "Confirmada")
            {
                DialogResult result = MessageBox.Show("Esta orden ya fue seleccionada. ¿Desea quitarla de la selección?", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    RevertirEstadoOrden(ordenSeleccionada);
                    return "Orden revertida a Seleccionada.";
                }
            }


            return null;

        }

        private void RevertirEstadoOrden(OrdenDePreparacion ordenSeleccionada)
        {
            ordenSeleccionada.EstadoOrden = "Seleccionada";
        }
    }


};
