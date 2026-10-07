using System;
using System.Collections.Generic;
using System.Text;

namespace AutoParts.Entity
{
    public class Compra
    {
        public int CompraId { get; set; }
        public string NumeroComprobante { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal TotalCompra { get; set; }

        public int ProveedorId { get; set; }
        public int EmpleadoId { get; set; }
    }
}
