using System;
using System.Collections.Generic;

namespace inventory_app.Models
{
    public partial class Productosmascaro
    {
        public int ClaveProducto { get; set; }
        public int NombreProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public int CantidaPorUnidad { get; set; }
        public int Precio { get; set; }
        public int UnidadesAlmacen { get; set; }
        public int UnidadesPedidas { get; set; }
        public int NivelReorden { get; set; }
        public int Descontinuado { get; set; }
    }
}
