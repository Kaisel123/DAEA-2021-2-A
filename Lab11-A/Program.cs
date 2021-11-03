using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// agregando dependencias
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities()) 
            //{
            // EJERCICIO K1. 
            //var products = AWEntities.Product;
            //IQueryable<string> productNames = from p in products
            //                                  select p.Name;

            //Console.WriteLine("Productos: ");
            //foreach (var producName in productNames)
            //{
            //    Console.WriteLine(producName);
            //}
            //Console.ReadKey();


            // EJERCICIO K2. 
            //var products = AWEntities.Product;
            //IQueryable<string> productNames = products.Select(p => p.Name);

            //Console.WriteLine("Productos: ");
            //foreach (var producName in productNames)
            //{
            //    Console.WriteLine(producName);
            //}


            // EJERCICIO K3. 
            //var products = AWEntities.Product;
            //IQueryable<Product> productsQuery = from p in products
            //                                    select p;
            //IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");

            //Console.WriteLine("Productos de tamaño 'L': ");
            //foreach (var product in largeProducts)
            //{
            //    Console.WriteLine(product.Name);
            //}
            //}




            //decimal totalDue = 500.00M;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            // EJERCICIO K6. (NO SE HACE)
            //var contacts = context.ContactType;
            //var orders = context.SalesOrderHeader;

            //var query = from contact in contacts
            //            from order in orders
            //            where contact.ContactTypeID == order.Con
            //                    && order.TotalDue < totalDue
            //            select new
            //            {
            //                ProductId = product.ProductID,
            //                ProductName = product.Name
            //            };
            //Console.WriteLine("Informacion de productos: ");
            //foreach (var productInfo in query)
            //{
            //    Console.WriteLine("Producto Id: {0}, Producto Name: {1}",
            //        productInfo.ProductId, productInfo.ProductName);
            //}
            //Console.ReadKey();


            // EJERCICIO K4.
            //IQueryable<Product> productsQuery = from product in context.Product
            //                                    select product;
            //Console.WriteLine("Productos: ");
            //foreach (var prod in productsQuery)
            //{
            //    Console.WriteLine(prod.Name);
            //}
            //Console.ReadKey();


            // EJERCICIO K5
            //var query = from product in context.Product
            //            select new
            //            {
            //                ProductId = product.ProductID,
            //                ProductName = product.Name
            //            };
            //Console.WriteLine("Informacion de productos: ");
            //foreach (var productInfo in query)
            //{
            //    Console.WriteLine("Producto Id: {0}, Producto Name: {1}", 
            //        productInfo.ProductId, productInfo.ProductName);
            //}
            //Console.ReadKey();
            //}












            //EJERCICIO K9
            //int orderQtyMin = 2;
            //int orderQtyMax = 6;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from order in context.SalesOrderDetail
            //                where order.OrderQty > orderQtyMin
            //                        && order.OrderQty < orderQtyMax
            //                select new
            //                {
            //                    SalesOrderID = order.SalesOrderID,
            //                    OrderQty = order.OrderQty
            //                };

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Order Id: {0}, Order quantity: {1}",
            //            order.SalesOrderID, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}



            //EJERCICIO K10
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    int?[] productModelIds = { 19, 26, 118 };
            //    var products = from p in AWEntities.Product
            //                   where productModelIds.Contains(p.ProductModelID)
            //                   select p;

            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("{0}: {1}",
            //            product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}


            //EJERCICIO K11 (TAMBIEN POR REVISAR)


            //EJERCICIO K12
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    IQueryable<Decimal> sortedPrices = from p in context.Product
            //                                       orderby p.ListPrice descending
            //                                       select p.ListPrice;
            //    Console.WriteLine("Lista de precios desde el más alto al más bajo:");
            //    foreach (Decimal price in sortedPrices)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    Console.ReadKey();
            //}



            //EJERCICIO K14
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var products = context.Product;
            //    var query = from product in products
            //                group product by product.Style into g
            //                select new
            //                {
            //                    Style = g.Key,
            //                    AverageListPrice = g.Average(product => product.ListPrice)
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Estilo: {0} Precio promedio: {1}",
            //            product.Style, product.AverageListPrice);
            //    }
            //    Console.ReadKey();
            //}




            //EJERCICIO K15
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };
                foreach (var product in query)
                {
                    Console.WriteLine("Color = {0} \t Cantidad = {1}",
                        product.Color, product.ProductCount);
                }
                Console.ReadKey();
            }
        }
    }
}
