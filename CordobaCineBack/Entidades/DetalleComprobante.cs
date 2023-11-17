﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DetalleComprobante
    {
        public int DetalleComprobanteId { get; set; }
        
        public Funciones Funciones { get; set; }

        
        public decimal Precio { get; set; }
        public Promociones PromocionesId { get; set; }

        public DetalleComprobante()
        { 
            Funciones= new Funciones();
        }
    }
}
