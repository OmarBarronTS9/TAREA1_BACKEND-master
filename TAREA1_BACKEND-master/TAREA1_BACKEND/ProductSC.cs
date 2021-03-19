using System;
using TAREA1_BACKEND.Northwind;

namespace TAREA1_BACKEND
{

    public class ProductSC : DBSC
    {
        public ProductSC()
        {
            //tenemos publico para que nuestro archivo principal pueda leerlo
            //Cumpliendo asi el principio de SOLID de Abierto/Cerrado
            public void SelectProduct(ID)
            {
                var ProductQry = new context.Products.Select(S => new {
                    S.ProductName,
                    S.UnitPrice,
                    S.UnitsInStock,
                    S.CategoryId
                }).Where(W => W.CategoryId == ID).AsQueryable();

                var output = ProductQry.ToList();
                output.ForEach(Fe => Console.WriteLine("Producto: " + Fe.ProductName +
                "  Precio Unitario: " + Fe.UnitPrice + "  Unidades en almacen: " + Fe.UnitsInStock));
            }

        }
    }
}
