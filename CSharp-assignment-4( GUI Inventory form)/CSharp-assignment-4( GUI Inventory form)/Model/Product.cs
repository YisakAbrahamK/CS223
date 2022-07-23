using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Model
{
    internal class Product
    {
        static private List<Product> products = new List<Product>();
        public int number { get; set; }
        public DateTime Date { get; set; }
        public int inventoryNumber { get; set; }
        public string objectName { get; set; }
        public int count { get; set; }
        public double price { get; set; }

        public void save()
        {
            products.Add(this);
        }

        public static List<Product> getAllProducts()
        {
            return products;
        }
    }

}
