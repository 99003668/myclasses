using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Category
    {
        public int id;
        public string name;
        public int price;
        public int quantity;
        public static List<Category> Electronics = new List<Category>();
        public static List<Category> Grocery = new List<Category>();
        public static List<Category> Cosmetics = new List<Category>();
        public static List<Category> Clothing = new List<Category>();
        public Category(int id, String name, int price, int quantity)
        {
            Electronics.Add(new Category(101, "Earphones", 100, 10));
            Electronics.Add(new Category(102, "charger", 500, 7));
            Electronics.Add(new Category(103, "Mobile", 17000, 6));
            Electronics.Add(new Category(104, "Laptop", 40000, 8));

            Grocery.Add(new Category(201, "soap", 100, 11));
            Grocery.Add(new Category(202, "toothpaste", 30, 13));
            Grocery.Add(new Category(203, "bru", 90, 5));
            Grocery.Add(new Category(204, "chocolates", 160, 15));

            Cosmetics.Add(new Category(301, "perfume", 400, 10));
            Cosmetics.Add(new Category(302, "lotion", 200, 5));
            Cosmetics.Add(new Category(303, "moisturizer", 600, 12));
            Cosmetics.Add(new Category(304, "lipstick", 500, 13));

            Clothing.Add(new Category(401, "shirt", 500, 10));
            Clothing.Add(new Category(402, "trousers", 800, 10));
            Clothing.Add(new Category(403, "t-shirts", 600, 10));
            Clothing.Add(new Category(404, "jeans", 1200, 10));
        }
        public void display()
        {
            //Electronics
            foreach (var element in Electronics)
            {
                Console.WriteLine("productid" + element.id + "productname" + element.name + "price" + element.price + "quantity" + element.quantity);
            }
            //Grocery
            foreach (var element in Grocery)
            {
                Console.WriteLine("productid" + element.id + "productname" + element.name + "price" + element.price + "quantity" + element.quantity);
            }
            //Cosmetics
            foreach (var element in Cosmetics)
            {
                Console.WriteLine("productid" + element.id + "productname" + element.name + "price" + element.price + "quantity" + element.quantity);
            }
            //Clothing
            foreach (var element in Clothing)
            {
                Console.WriteLine("productid" + element.id + "productname" + element.name + "price" + element.price + "quantity" + element.quantity);
            }

        }
    }
}
