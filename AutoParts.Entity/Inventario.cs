using System;
using System.Collections.Generic;
using System.Text;

namespace AutoParts.Entity
{
    public class Inventario
    {
        public int InventarioId { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }

        public int ProductoId { get; set; }
        public int EstadoId { get; set; }
    }
}