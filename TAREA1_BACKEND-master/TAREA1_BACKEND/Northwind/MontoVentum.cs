using System;
using System.Collections.Generic;

#nullable disable

namespace TAREA1_BACKEND.Northwind
{
    public partial class MontoVentum
    {
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public double? Suma { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
