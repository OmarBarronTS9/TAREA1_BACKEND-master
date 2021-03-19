using System;
using System.Collections.Generic;

#nullable disable

namespace TAREA1_BACKEND.Northwind
{
    public partial class Detalle
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
