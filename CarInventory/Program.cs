/*
 *  CarInventory
 *  To hold cars in a database
 *  
 *  Revision History
 *      Tony Theo.... 2023.04.03:  Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    internal class Program
    {
        static List<Car> cars = new List<Car>();

        static void Main(string[] args)
        {
            string menuChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. Display all cars");
                Console.WriteLine("3. Go for a drive");
                Console.WriteLine("4. Set the price");
                Console.WriteLine("5. Exit");
                menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    AddCar();
                }
                else if (menuChoice == "2")
                {
                    DisplayCars();
                }
                else if (menuChoice == "3")
                {
                    GoDriving();
                }
                else if (menuChoice == "4")
                {
                    ChangePrice();
                }
                else if (menuChoice == "5")
                {
                    Console.WriteLine("Bye for now");
                }
                else
                {
                    Console.WriteLine("Please select an option 1 - 5");
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadKey();
                }

            } while (menuChoice != "5");

            Console.ReadKey();
        }

        static void AddCar()
        {
            string make, year;
            int mileage;

            Console.Clear();
            Console.Write("Enter a year: ");
            year = Console.ReadLine();

            Console.Write("Enter a make: ");
            make = Console.ReadLine();

            Console.Write("Enter the mileage: ");
            mileage = Convert.ToInt16(Console.ReadLine());

            Car newCar = new Car(year, make, mileage);
            cars.Add(newCar);
        }

        static void DisplayCars()
        {
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    Console.WriteLine($"{cars[i].make} {cars[i].year} - {cars[i].mileage}km");
            //}

            foreach (Car c in cars)
            {

                Console.WriteLine($"{c.make} {c.year} - {c.mileage}km, ${c.GetPrice()}");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        static void GoDriving()
        {
            string make;
            int index = -1;
            int distance = 0;

            Console.WriteLine("Which car do you want to drive?");
            make = Console.ReadLine();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].make == make)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                Console.WriteLine("How far do you want to drive:");
                distance = Convert.ToInt32(Console.ReadLine());

                cars[index].Drive(distance);
            }
            else
            {
                Console.WriteLine("Car not found");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void ChangePrice()
        {
            string make;
            int index = -1;
            int price = 0;

            Console.WriteLine("Pick a car?");
            make = Console.ReadLine();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].make == make)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                Console.WriteLine("What's the price?");
                price = Convert.ToInt32(Console.ReadLine());

                cars[index].SetPrice(price);
            }
            else
            {
                Console.WriteLine("Car not found");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
