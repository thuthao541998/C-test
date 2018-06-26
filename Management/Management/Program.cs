using System;
using System.Collections.Generic;
using System.Linq;

namespace Management {

    class Program {

        static void Main (string[] args) {
            GenerateMenu ();
        }
        public static void GenerateMenu () {
            List<Product> list = new List<Product> ();
            while (true) {
                System.Console.WriteLine ("Product Management");
                System.Console.WriteLine ("___________________");
                System.Console.WriteLine ("1.Add product records");
                System.Console.WriteLine ("2.Display product records");
                System.Console.WriteLine ("3.Delete product by id");
                System.Console.WriteLine ("4.Exit");
                System.Console.WriteLine ("Please enter choice");
                var choice = Int32.Parse (Console.ReadLine ());
                switch (choice) {
                    case 1:
                        Add (list);
                        break;
                    case 2:
                        Display (list);
                        break;
                    case 3:
                        Delete (list);
                        break;
                    case 4:
                        Console.WriteLine ("See you later.");
                        Environment.Exit (1);
                        break;
                    default:
                        System.Console.WriteLine ("Wrong choice");
                        break;
                }
            }
        }
        public static void Add (List<Product> list) {
            System.Console.WriteLine ("Add Product");
            System.Console.WriteLine ("Please enter product ID");
            var productID = Console.ReadLine ();
            System.Console.WriteLine ("Please enter product Name");
            var productName = Console.ReadLine ();
            System.Console.WriteLine ("Please enter product Price");
            var price = Decimal.Parse (Console.ReadLine ());
            Product product = new Product (productID, productName, price);
            list.Add (product);
        }
        public static void Delete (List<Product> list) {
            System.Console.WriteLine ("Delete Product");
            System.Console.WriteLine ("Plese enter product ID to delete");
            var deleteID = Console.ReadLine ();
            foreach (var p in list.Where (product => product.ProductId == deleteID).ToArray ()) {
                list.Remove (p);
                System.Console.WriteLine ("Delete successful!");
            };

        }
        public static void Display (List<Product> list) {
            System.Console.WriteLine ("{0,15}|{1,15}|{2,15}", "Product ID", "Product Name", "Price");
            foreach (var product in list) {
                System.Console.WriteLine ("{0,15}|{1,15}|{2,15}", product.ProductId, product.ProductName, "$" + product.Price);
            }
        }
    }
}