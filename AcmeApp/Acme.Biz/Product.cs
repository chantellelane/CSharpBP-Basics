using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Instatiation of a object");
        }

        public Product(int productId, string productName, string description) : this()
        {
           this.ProductName = productName;
           this.ProductId = this.productId;
           this.Description = description;
            
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string Display()
        {
            return $"{ProductName} {ProductId} {Description}";
        }


    }

    
}
