using System;
using System.Collections.Generic;
using System.Text;

namespace AutoParts.Entity
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string CodigoOEM { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int TiempoGarantia { get; set; }

        public int CategoriaId { get; set; }
        public int EstadoId { get; set; }

    }
}
