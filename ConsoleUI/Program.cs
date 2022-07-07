using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Abstract(soyut nesnleri) interface,base class, abstractlar içerisine referans tutucu sınıflar ekle
        //Concrete(somut) gerçek işi yapan sınıflar ekle
        //SOLID
        //Open Closed Principle
        //IoC
        //Data Transformation object
        static void Main(string[] args)
        {
            ProductManager();

            //CategorymanagerTest();

        }

        private static void CategorymanagerTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductManager()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " = " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
            
        }
    }
}
