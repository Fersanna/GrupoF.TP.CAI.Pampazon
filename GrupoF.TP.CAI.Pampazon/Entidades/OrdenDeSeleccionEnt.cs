﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class OrdenDeSeleccionEnt
    {

        public string IdOrdenDeSeleccion { get; set; }

        public EstadoSeleccion EstadoOrdenSeleccion { get; set; }

        public List<OrdenDeSeleccionDetalle> SeleccionDetalle { get; set; } 

        public OrdenDeSeleccionEnt()
        {

        }
    }
}
