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

        public int sale { get; set; }
        public FoodAndBeverages(String name, String brand, Double price, DateTime expirationDate) {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.expirationDate = expirationDate;
            this.sale = Discount();
        }

        public int Discount()
        {
            if ( DateTime.Now == expirationDate)
            {
                sale = 50;
            }
            else if (expirationDate.Day == (DateTime.Now.Day + 5))
            {
                sale = 10;
            }

            else sale = 0;


            return sale;
        }
    }

}
