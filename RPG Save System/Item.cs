using System;
using System.Collections.Generic;
using System.Text;

namespace Item
{
    public class Items
    {
        private string name;

        private int quantity;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Name cannot be empty");
                else
                    name = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Quantity cannot be negative");
                else
                    quantity = value;
            }
        }


        public Items(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;




        }
    }
}
