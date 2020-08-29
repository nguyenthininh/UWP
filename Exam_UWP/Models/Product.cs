using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam_UWP.Models.Product;

namespace Exam_UWP.Models
{
   public class Product
    {

        public enum ProductCategory
        {
            bautroi,
            cogai,
            khungcanh,
        }

        public string name { get; set; }
        public string description { get; set; }
        public string img { get; set; }

        public Product(string name, string description , ProductCategory category )
        {
            name = name;
            description = description;
            img = String.Format("/Assets/Images/{0}/{1}.jpg", category,name);

        }

    }
   public class ProductManager
    {
        private static List<Product> getProducts()
        {
            var products = new List<Product>();
            products.Add(new Product("khungcanh","New 100 % " ,ProductCategory.khungcanh));
            products.Add(new Product("cogai","99 %", ProductCategory.cogai));
            products.Add(new Product("bautroi","90 % ", ProductCategory.bautroi));

            return products;

        }
        public static void GetAllproduct(ObservableCollection<Product> products)
        {
            var allProduct = getProducts();
            products.Clear();
            allProduct.ForEach(p => products.Add(p));
        }

        public static void addProduct(Product products, ObservableCollection<Product> productList)
        {
            var allProduct = getProducts();
            productList.Clear();
            allProduct.ForEach(p => productList.Add(p));

        }
    }
}
