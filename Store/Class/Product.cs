using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Class
{
  public  class Product
    { 
        public string name { get; set; }
        
        public string brand { get; set; }

        public double price { get; set; }
        public Product()
        {         
            this.name = null;
            this.brand = null;
            this.price = 0;
        }

        public Product(String name, String brand, Double price) {
          
            this.name = name;
            this.brand = brand;
            this.price = price;
        }
    }  
}
