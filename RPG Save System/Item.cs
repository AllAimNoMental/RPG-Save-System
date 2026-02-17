using System;
using System.Collections.Generic;
using System.Text;

namespace Item
{
    public class Items
    {
        private string name;
        private int quantity;



        public Items(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;

        }
        public bool NotNegative(int number)
        {
            if (number > 0)
            {
                quantity = number;
                return true;
            }
            Console.WriteLine("Quantity can not be negative or zero");
            return false;

        }
        public bool NameNotEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name can not be empty");
                return false;
            }
            Console.WriteLine("Name set succesfully");
            return true;
        }
    }

}
