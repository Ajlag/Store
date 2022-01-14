﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Class
{
    enum Size{
        XS,
        S,
        M,
        L,
        XL
    }
    class Clothes : Product
    {
        public Size size { get; set; }

        public String color { get; set; }

      public  int popust { get; set; }
        public Clothes( String name, String brand, Double price, Size size, String color) {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.size = size;
            this.color = color;
            this.popust = Discount();
        }

        public int Discount()
        {
            if (DateTime.Now.DayOfWeek!=DayOfWeek.Saturday && DateTime.Now.DayOfWeek!=DayOfWeek.Sunday)
            {
                popust = 10;
            }
          
            else popust = 0;


            return popust;
        }
    }
}
