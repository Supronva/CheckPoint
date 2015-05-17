using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.ClassTaxiStation;
using TaxiStation.InterfaceTaxiStation;

namespace TaxiStation
{
    class Program
    {
        static void Main(string[] args)
        {
            CarStation station = new CarStation() { CollectionNameTaxiStation = "Тачки"};
            station.Add(new Crossover() { MarkaVehicler = MarkaVehicle.Audi, Name = "Q3", PriceCar = 25000, SpeedCar = 240, ExpenseFuel = 10, CoutPassengerSeat = CoutPassengerSeat.Five, TypeFuel = TypeFuel.Benzine, VEngine = 3 });
            station.Add(new Hatchback() { MarkaVehicler = MarkaVehicle.Opel, Name = "Astra", PriceCar = 6000, SpeedCar = 200, ExpenseFuel = 7, CoutPassengerSeat = CoutPassengerSeat.Five, TypeFuel = TypeFuel.Benzine, VEngine = 1.6 });
            station.Add(new Sedan() { MarkaVehicler = MarkaVehicle.Ford, Name = "Siera", PriceCar = 2000, SpeedCar = 180, ExpenseFuel = 8, CoutPassengerSeat = CoutPassengerSeat.Five, TypeFuel = TypeFuel.Diesel, VEngine = 2 });
            station.Add(new SportsCar() { MarkaVehicler = MarkaVehicle.Porsche, Name = "996 GT3", PriceCar = 40000, SpeedCar = 300, ExpenseFuel = 12, CoutPassengerSeat = CoutPassengerSeat.Two, Listtuning = ListTuning.ExtendedEngine, TypeFuel = TypeFuel.Benzine, VEngine = 4 });
            station.Add(new Minivan() { MarkaVehicler = MarkaVehicle.Volkswagen, Name = "Sharan", PriceCar = 10000, SpeedCar = 200, ExpenseFuel = 9, CoutPassengerSeat = CoutPassengerSeat.Eight, FoldingDoor =true, TypeFuel = TypeFuel.Diesel, VEngine = 2.2 });
            string user_command = "";
            
            // бесконечный цикл 
            bool Infinity = true;

            while (Infinity) // пока Infinity равно true 
            {
                // приглашение ввести команду 
                Console.WriteLine("Автопарк - {0}",station.CollectionNameTaxiStation);
                Console.WriteLine("Пожалуйста, введите команду: help-справка; exit-выход из програмы");
                Console.WriteLine(new string('=', 79));
                // получение строки (команды) от пользователя 
                user_command = System.Console.ReadLine();

                switch (user_command)
                {

                    // если user_command содержит строку exit 
                    case "exit":
                        {
                            Infinity = false;
                            // теперь цикл завершиться, и программа завершит свое выполнение 
                            break;
                        }

                    // если user_command содержит строку help 
                    case "help":
                        {
                            Console.WriteLine("Список команд:");
                            Console.WriteLine(new string('-', 79));
                            Console.WriteLine("listcar - список машин автопарка");
                            Console.WriteLine("sort - сортировка по расходу топлива");
                            Console.WriteLine("sum - общая стоимость автопарка");
                            Console.WriteLine("search - диапозон машин от 180-220 км/час");
                            Console.WriteLine(new string('-', 79));

                            break;
                        } // если команду определить не удалось 

                    default:
                        {
                            Console.WriteLine("Ваша команда не определена, пожалуйста, повторите снова");
                            Console.WriteLine("Для вывода списка команд введите команду help");
                            Console.WriteLine("Для завершения программы введите команду exit");
                            break;
                        }
                    //если user_command содержит строку sum
                    case "sum":
                        {
                            int s = 0;
                            foreach (var i in station)
                            {
                                s += i.PriceCar;
                            }
                            Console.WriteLine("Общая стоимость *Автопарка* = {0} у.е", s);
                            Console.WriteLine("Кол-во автомобилий автопарка = {0}",station.Count());
                            break;
                        }
                       //если user_command содержит строку sort
                    case "sort":
                        {
                            station.SortBy();
                            foreach (var i in station)
                            {
                                Console.WriteLine("Марка - {0} Название - {1} Цена - {2} MaxСкорость - {3} РасходТоплива - {4}",i.MarkaVehicler,i.Name,i.PriceCar,i.SpeedCar,i.ExpenseFuel);
                            }
                            break;
                        }
                      //если user_command содержит строку search
                    case "search":
                        {
                            IEnumerable<IVehicle> coll = station.GetCarsDiapasoneForSpeedCar(180,220 );

                            foreach (var i in coll)
                            {
                                Console.WriteLine("Марка - {0} Название - {1} MaxСкорость - {2}", i.MarkaVehicler, i.Name,i.SpeedCar);
                            }
                            break;
                        }
                    //если user_command содержит строку listcar
                    case "listcar":
                        {
                            foreach (var i in station)
                            {
                                Console.WriteLine("Марка - {0} Название - {1} Цена - {2} MaxСкорость - {3} РасходТоплива - {4}", i.MarkaVehicler, i.Name, i.PriceCar, i.SpeedCar, i.ExpenseFuel);
                            }
                            break;
                        }

                }

            }

        }
    }
}
