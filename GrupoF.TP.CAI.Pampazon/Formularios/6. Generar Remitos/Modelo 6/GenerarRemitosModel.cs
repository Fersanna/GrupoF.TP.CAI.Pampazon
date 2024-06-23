﻿using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos.Clases_Auxiliares_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public class GenerarRemitosModel
    {
        public OrdenDeEntregaPendiente OrdenSeleccionada { get; internal set; }
        public List<OrdenDeEntregaPendiente> OrdenesDeEntrega { get; set; } = new List<OrdenDeEntregaPendiente>();

        public Remito RemitoAGuardar {get; set; }


        public GenerarRemitosModel()
        {
            var ordenesDeEntrega = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts;

            if (ordenesDeEntrega != null)
            {
                OrdenesDeEntrega = ordenesDeEntrega
                                                .Select(ordenEnt => new OrdenDeEntregaPendiente
                                                {
                                                    IdOrdenDeEntrega = ordenEnt.IdOrdenDeEntrega,
                                                    CodigoCliente = ordenEnt.CodigoCliente,
                                                    Fecha = ordenEnt.Fecha,
                                                    CodigoTransportista = ordenEnt.CodigoTransportista,
                                                    EstadoOrdenEntrega = ordenEnt.EstadoOrdenEntrega,
                                                    EntregaDetalle = ordenEnt.EntregaDetalle.Select(d => d.NumeroDeOrden).ToList()
                                                })
                                                .ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de selección");
            }


            /*
            
            OrdenesDeEntrega = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts.Select(ordenEnt => new OrdenDeEntregaPendiente
            {
                IdOrdenDeEntrega = ordenEnt.IdOrdenDeEntrega,
                Fecha = ordenEnt.Fecha,
               // EstadoOrden = ordenEnt.EstadoEntrega,
               //Hay que hacer una nueva clase auxiliar 
            }
              ).ToList();

            */
        }

        internal void CambiarEstadoOrdenSeleccionada()
        {
            var ordenSeleccionada = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts.FirstOrDefault(o => OrdenSeleccionada.IdOrdenDeEntrega == o.IdOrdenDeEntrega);

            ordenSeleccionada.EstadoOrdenEntrega = Entidades.EstadoEntregaEnum.EstadoEntrega.Asignado;
        }

        internal void GuardarRemito()
        {
            var numerosDeOrden = OrdenSeleccionada.EntregaDetalle;
           
            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenesDePreparacion
                 .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
                 .ToList();

            var detalleProductos = new List<Productos>();

            foreach (var ordenDePreparacion in ordenesDePreparacion)
            {
                foreach (var detalle in ordenDePreparacion.Detalle)
                {
                    var productoAlmacen = AlmacenProductos.Productos
                                                   .Single(p => p.IdProducto == detalle.IdProducto);
                    if (productoAlmacen != null)
                    {
                        // Crear una instancia del producto con la cantidad correspondiente
                        var producto = new Productos
                        {
                            IdProducto = productoAlmacen.IdProducto,
                            Descripcion = productoAlmacen.Descripcion,
                            Cantidad = detalle.Cantidad
                        };

                        // Agregar el producto a la lista de detalles del remito
                        detalleProductos.Add(producto);
                    }
                }
            }
            var remito = new RemitosEnt
            {
               // IdRemito = ObtenerNuevoIdRemito(), 
                FechaRemito = DateTime.Now,
                CodigoCliente = OrdenSeleccionada.CodigoCliente,
                //Aca meti una brutalidad para poder obtener los productos ya que no encuentro el numero de orden arriba.
                DetalleProductos = RemitoAGuardar.Detalle.ToList()
            };

            
            AlmacenRemitos.RemitosEnt.Add(remito); 
            AlmacenRemitos.Grabar();
            
            MessageBox.Show($"Remito guardado con ID: {remito.IdRemito}");

        }
    }
}
