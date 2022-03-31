using System;
using System.Collections.Generic;

namespace inventory_app.Models
{
    public partial class EmpleadosVenta
    {
        public int Firstname { get; set; }
        public int Lastname { get; set; }
        public int City { get; set; }
        public int Ordenes { get; set; }
        public int Monto { get; set; }
    }
}
