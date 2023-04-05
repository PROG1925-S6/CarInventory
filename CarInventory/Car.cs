/*  Car.cs
 *  Define the properties and behaviours of a Car
 *  
 *  Revision History 
 *     Tony Theo... 2023.04.03:  Created
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    internal class Car
    {
        public string year, make;
        public int mileage;

        private int price;

        //Default Constructor - include in all classes
        public Car()
        {
        }

        public Car(string year, string make, int mileage)
        {
            this.year = year;
            this.make = make;
            this.mileage = mileage;
        }

        public void Drive(int km)
        {
            mileage = mileage + km;
        }

        public void SetPrice(int newPrice)
        {
            price = newPrice;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
