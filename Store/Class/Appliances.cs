using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Class
{
    class Appliances : Product
    {
        public String model { get; set; }

        public DateTime productionDate { get; set; }

        public Double weight { get; set; }
        int sale { get; set; }
        public Appliances(String name, String brand, Double price, String model, DateTime productionDate, Double weight) {
            this.name = name;
            this.brand = brand;
            this.brand = brand;
            this.price = price;
            this.model = model;
            this.productionDate = productionDate;
            this.weight = weight;
            this.sale = Discount();
        }

        public int Discount()
        {
            if ((DateTime.Now.DayOfWeek!=DayOfWeek.Sunday || DateTime.Now.DayOfWeek!=DayOfWeek.Saturday) && price<999)
            {
                sale = 0;
            }
            else sale = 5;


            return sale;
        }

    }
}
