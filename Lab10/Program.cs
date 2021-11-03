using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Origen de datos
            NorthwndDataContext context = new NorthwndDataContext();

            //PUTNO G
            //var query = from p in context.Products
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //}

            //Console.ReadKey();

            //PUNTO H
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //}

            //Console.ReadKey();

            //PUNTO I
            //var query = from p in context.Products
            //            where p.UnitPrice < 20
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}

            //Console.ReadKey();

            // PUNTO J
            //J.1
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.ProductName, "%Queso%")
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}

            //Console.ReadKey();

            //J.2
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.QuantityPerUnit, "%pkg%") ||
            //                  SqlMethods.Like(p.QuantityPerUnit, "%pkgs%")
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}

            //Console.ReadKey();

            //J.3
            //var query = from p in context.Products
            //            where p.ProductName.StartsWith("A")
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}

            //Console.ReadKey();

            //J.4
            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1} \t Stok={2}", prod.ProductID, prod.ProductName, prod.UnitsInStock);
            //}

            //Console.ReadKey();

            //J.5
            //var query = from p in context.Products
            //            where p.Discontinued == true
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1} \t Descontinuado={2}", prod.ProductID, prod.ProductName, prod.Discontinued);
            //}

            //Console.ReadKey();


            //Insertar datos
            //Products p = new Products();
            //p.ProductName = "Peruvian Coffe";
            //p.SupplierID = 20;
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;

            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();


            //Insertar registro en la tabla Categories
            //Categories c = new Categories();
            //c.CategoryName = "Comida";
            //c.Description = "todo tipo de comidas enlatadas";

            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();

            //var query = from ca in context.Categories
            //            select ca;

            //foreach (var cat in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", cat.CategoryID, cat.CategoryName);
            //}

            //PUNTO N
            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //               select p).FirstOrDefault();

            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;

            //context.SubmitChanges();


            //PUNTO O
            //var product = (from p in context.Products
            //               where p.ProductID == 78
            //               select p).FirstOrDefault();

            ////Ejecución de consulta
            //context.Products.DeleteOnSubmit(product);
            //context.SubmitChanges();

            //TAREA LABORATORIO
            //PUNTO 1
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Dairy Products"
            //            select p;

            ////Ejecucion de la consulta
            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Nombre={1,-25} \t Nombre Proveedor={2,-30} \t Categoria={3}",
            //        prod.ProductID, prod.ProductName, prod.Suppliers.CompanyName, prod.Categories.CategoryName);
            //}

            //Console.ReadKey();

            //PUNTO 2
            var query = from p in context.Products
                        where p.Suppliers.Country == "USA"
                        select p;

            //Ejecucion de la consulta
            foreach (var prod in query)
            {
                Console.WriteLine("Productos={0,-35} \t Nombre Proveedor={1,-25} \t Pais={2}",
                    prod.ProductName, prod.Suppliers.CompanyName, prod.Suppliers.Country);
            }

            Console.ReadKey();
        }
    }
}
