using System;
using System.Collections.Generic;

#nullable disable

namespace TAREA1_BACKEND.Northwind
{
    public partial class Venta
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int? Ventas { get; set; }
    }
}
