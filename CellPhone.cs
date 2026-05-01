using System;
using System.Collections.Generic;
using System.Text;

namespace Cell_Phone_Test
{
    public class CellPhone 
    {
        public CellPhone()
        {
            Brand = "";
            Model = "";
            Price = 0m;
        }

        public string Brand{ get; set; }
        public string Model {  get; set; }

        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative!");
                else
                    price = value;
                    
            }
           
        }

        
    }
}
