﻿using GrupoF.TP.CAI.Pampazon.Entidades;

namespace GrupoF.TP.CAI.Pampazon.Clases_Auxiliares
{
    public class Productos
    {
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public  string Posicion {get ; set;}
        public int Cantidad {get; set;}

        public Productos(ProductoEnt productoEnt)
        {
            IdProducto = productoEnt.IdProducto;
            Descripcion = productoEnt.Descripcion;
            Posicion = productoEnt.Posicion;
            Cantidad = productoEnt.Stock;
        }

        public Productos()
        {

        }
    }
}