using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.ClassCarPark;
using CarPark.InterfaceCarPark;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            CarStation station = new CarStation() { CollectionNameTaxiStation = "Funny Car" };
            station.Add(new Crossover() { MarkaVehicler = MarkaVehicle.Audi, Name = "Q3", PriceCar = 25000, SpeedCar = 240, ExpenseFuel = 10, CoutPassengerSeat = CoutPassengerSeat.Five, TypeFuel = TypeFuel.Benzine, VEngine = 3 });
            station.Add(new Hatchback() { MarkaVehicler = MarkaVehicle.Opel, Name = "Astra", PriceCar = 6000, SpeedCar = 200, ExpenseFuel = 7, CoutPassengerSeat = CoutPassengerSeat.Five, TypeFuel = TypeFuel.Benzine, VEngine = 1.6 });
            station.Add(new Sedan() { MarkaVehicler = MarkaVehicle.Ford, Name = "Siera", PriceCar = 2000, SpeedCar = 180, ExpenseFuel = 8, CoutPassengerSeat = CoutPassengerSeat.Five, TypeFuel = TypeFuel.Diesel, VEngine = 2 });
            station.Add(new SportsCar() { MarkaVehicler = MarkaVehicle.Porsche, Name = "996 GT3", PriceCar = 40000, SpeedCar = 300, ExpenseFuel = 12, CoutPassengerSeat = CoutPassengerSeat.Two, Listtuning = ListTuning.ExtendedEngine, TypeFuel = TypeFuel.Benzine, VEngine = 4 });
            station.Add(new Minivan() { MarkaVehicler = MarkaVehicle.Volkswagen, Name = "Sharan", PriceCar = 10000, SpeedCar = 200, ExpenseFuel = 9, CoutPassengerSeat = CoutPassengerSeat.Eight, FoldingDoor =true, TypeFuel = TypeFuel.Diesel, VEngine = 2.2 });
            string user_command = "";
        
            bool Infinity = true;

            while (Infinity)
            {
                Console.WriteLine("CarPark - {0}",station.CollectionNameTaxiStation);
                Console.WriteLine("Please enter the following command: help ; exit");
                Console.WriteLine(new string('=', 79));
                user_command = System.Console.ReadLine();
                switch (user_command)
                {
                    case "exit":
                        {
                            Infinity = false;
                            break;
                        }
                    case "help":
                        {
                            Console.WriteLine("Team List");
                            Console.WriteLine(new string('-', 79));
                            Console.WriteLine("listcar - List of machines");
                            Console.WriteLine("sort - Sort on fuel consumption");
                            Console.WriteLine("sum - The total cost of carpark");
                            Console.WriteLine("search - Range of speed machines from 180-220 ");
                            Console.WriteLine(new string('-', 79));
                            break;
                        } 

                    default:
                        {
                            Console.WriteLine("Your team is not defined, please try again");
                            Console.WriteLine("For a list of commands, enter the command help");
                            Console.WriteLine("To terminate the program, type the command exit");
                            break;
                        }
                    case "sum":
                        {
                            int s = 0;
                            foreach (var i in station)
                            {
                                s += i.PriceCar;
                            }
                            Console.WriteLine("The total value of cars = {0} $", s);
                            Console.WriteLine("Quantity of car = {0}", station.Count());
                            break;
                        }
                    case "sort":
                        {
                            station.SortBy();
                            foreach (var i in station)
                            {
                                Console.WriteLine("Car - {0} NameCar - {1} PriceCar - {2} MaxSpeed- {3} Expense - {4}", i.MarkaVehicler, i.Name, i.PriceCar, i.SpeedCar, i.ExpenseFuel);
                            }
                            break;
                        }
                    case "search":
                        {
                            IEnumerable<IVehicle> coll = station.GetCarsDiapasoneForSpeedCar(180,220 );

                            foreach (var i in coll)
                            {
                                Console.WriteLine("Car - {0} NameCar- {1} MaxSpeed - {2}", i.MarkaVehicler, i.Name, i.SpeedCar);
                            }
                            break;
                        }
                    case "listcar":
                        {
                            foreach (var i in station)
                            {
                                Console.WriteLine("Car - {0} NameCar- {1} PriceCar - {2} MaxSpeed - {3} Expense {4}", i.MarkaVehicler, i.Name, i.PriceCar, i.SpeedCar, i.ExpenseFuel);
                            }
                            break;
                        }
                }
            }
        }
    }
}
