using System;
using System.Collections.Generic;
using System.Text;

namespace AutoParts.Entity
{
    public class Detalle_Compra
    {
        public int DetalleCompraId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal Subtotal { get; set; }

        public int CompraId { get; set; }
        public int ProductoId { get; set; }
    }
}
