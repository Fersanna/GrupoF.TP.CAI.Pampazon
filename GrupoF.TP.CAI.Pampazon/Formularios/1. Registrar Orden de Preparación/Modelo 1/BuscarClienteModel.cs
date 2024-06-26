﻿using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Modulos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Modelos
{
    public class BuscarClienteModel
    {
        public Clientes ClienteSeleccionado { get; set; }
        public OrdenDePreparacion ClienteOrden { get; set; }
        public string Cuit { get; set; }
        public List<Clientes> Clientes { get; set; }



        public BuscarClienteModel()
        {
            var clientesLista = ModuloClientes.ObtenerListaClientes();
            var productos = AlmacenProductos.Productos;

            Clientes = clientesLista.Select(clienteEnt =>
             {
                 var productosCliente = clienteEnt.IdProductos
                     .Select(idProducto =>
                     {
                         var producto = productos.FirstOrDefault(p => p.IdProducto == idProducto);
                         return producto != null ? new Productos(producto) : null;
                     })
                     .Where(p => p != null)
                     .ToList();

                 return new Clientes
                 {
                     CodigoCliente = clienteEnt.CodigoCliente,
                     RazonSocial = clienteEnt.RazonSocial,
                     Cuit = clienteEnt.Cuit,
                     Domicilio = clienteEnt.Domicilio,
                     Productos = productosCliente
                 };
             }).ToList();
        }

        internal string QuitarProductoDelaOrden(Productos producto)
        {
            if (producto != null)
            {
                // Busca el producto en la lista de productos de la orden y lo elimina
                var productoEncontrado = ClienteOrden.ProductosOrden.FirstOrDefault(p => p.IdProducto == producto.IdProducto);
                if (productoEncontrado != null)
                {
                    ClienteOrden.ProductosOrden.Remove(productoEncontrado);
                    return null; // No hay error
                }
                else
                {
                    return "El producto seleccionado no se encontró en la orden.";
                }
            }
            else
            {
                return "El producto seleccionado es nulo.";
            }
        }

        internal string ValidarCantidadProductos()
        {
            if (ClienteOrden == null || ClienteOrden.ProductosOrden == null || !ClienteOrden.ProductosOrden.Any())
            {
                return "Debe agregar al menos un producto para generar la orden.";
            }



            var clienteEncontrado = Clientes.FirstOrDefault(c => c.CodigoCliente == ClienteOrden.CodigoCliente);

            if (clienteEncontrado == null)
            {
                return "El cliente no se ha encontrado.";
            }

            foreach (var productoOrden in ClienteOrden.ProductosOrden)
            {
                var productoCliente = clienteEncontrado.Productos?.FirstOrDefault(p => p.IdProducto == productoOrden.IdProducto);
                if (productoCliente == null)
                {
                    return $"Producto con ID {productoOrden.IdProducto} no encontrado en la lista del cliente.";
                }
                if (productoOrden.Cantidad > productoCliente.Cantidad)
                {
                    return $"La cantidad pedida para el producto {productoOrden.IdProducto} excede la cantidad disponible. Disponible: {productoCliente.Cantidad}, Pedida: {productoOrden.Cantidad}.";
                }
                if (productoOrden.Cantidad <= 0)
                {
                    return $"La cantidad pedida para el producto {productoOrden.IdProducto} debe ser mayor que cero.";
                }

            }

            return null;
        }

        internal void GenerarNuevaOrdenDePreparacion()
        {
            var validacion = ValidarCantidadProductos();
            if (validacion != null)
            {
                throw new InvalidOperationException(validacion);
            }

            // Actualizar el inventario de productos
            foreach (var productoOrden in ClienteOrden.ProductosOrden)
            {
                var productoInventario = AlmacenProductos.Productos.FirstOrDefault(p => p.IdProducto == productoOrden.IdProducto);
                if (productoInventario != null)
                {

                    productoInventario.Stock -= productoOrden.Cantidad;

                    var productoCliente = ClienteSeleccionado.Productos.FirstOrDefault(p => p.IdProducto == productoOrden.IdProducto);

                    if (productoCliente != null)
                    {
                        productoCliente.Cantidad -= productoOrden.Cantidad;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Producto con ID {productoOrden.IdProducto} no encontrado en la lista de productos del cliente.");
                    }
                }

                else
                {
                    throw new InvalidOperationException($"Producto con ID {productoOrden.IdProducto} no encontrado en el inventario.");
                }
            }

            var ordenDePreparacionEnt = ConvertirOrden(ClienteOrden);
            AlmacenOrdenesDePreparacion.AgregarOrden(ordenDePreparacionEnt);
            MessageBox.Show("La orden fue cargada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        internal OrdenDePreparacionEnt ConvertirOrden(OrdenDePreparacion orden)
        {
            /*
            var ultimoNumeroOrdenPreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacion.OrderByDescending(o => o.NumeroDeOrden)
         .FirstOrDefault();

            int ultimoId = 0;

            if (ultimoNumeroOrdenPreparacion != null && int.TryParse(ultimoNumeroOrdenPreparacion.NumeroDeOrden, out int id))
            {
                ultimoId = id;
            }

            ultimoId++;
            string nuevoNumeroOrdenPrep = ultimoId.ToString();
            */

            int ultimoId = 0;

            // Buscar el último número de orden en el AlmacenOrdenesDePreparacion
            if (AlmacenOrdenesDePreparacion.OrdenDePreparacion.Any())
            {
                var ultimoNumeroOrdenPreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacion
                    .OrderByDescending(o => int.Parse(o.NumeroDeOrden))
                    .FirstOrDefault();

                if (ultimoNumeroOrdenPreparacion != null && int.TryParse(ultimoNumeroOrdenPreparacion.NumeroDeOrden, out int id))
                {
                    ultimoId = id;
                }
            }

            // Incrementar el último ID para obtener el nuevo número de orden
            ultimoId++;
            string nuevoNumeroOrdenPrep = ultimoId.ToString();
            
            return new OrdenDePreparacionEnt
            {
                NumeroDeOrden = nuevoNumeroOrdenPrep,
                Fecha = orden.Fecha,
                CodigoCliente = orden.CodigoCliente,
                CodigoTransportista = orden.CodigoTransportista,
                EstadoOrden = EstadoPreparacion.Pendiente,
                Prioridad = (Prioridad)(int)orden.Prioridad,

                Detalle = orden.ProductosOrden.Select(p => new OrdenDePreparacionDetalle
                {
                    IdProducto = p.IdProducto,
                    Cantidad = p.Cantidad
                }).ToList()
            };
        }
    }
}



