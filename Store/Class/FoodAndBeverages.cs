using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Class
{
  public class FoodAndBeverages : Product
    {
        public FoodAndBeverages() : base() { }

        public DateTime expirationDate;

        public int popust { get; set; }
        public FoodAndBeverages(String name, String brand, Double price, DateTime expirationDate) {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.expirationDate = expirationDate;
            this.popust = Discount();
        }

        public int Discount()
        {
            if (expirationDate.Day == DateTime.Now.Day)
            {
                popust = 50;
            }
            else if (expirationDate.Day == (DateTime.Now.Day + 5))
            {
                popust = 10;
            }

            else popust = 0;


            return popust;
        }
    }

}
