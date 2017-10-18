using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEiSystems
{
    class NewCarSalesman
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            CarMethods methods = new CarMethods();
            List<Car> list = car.PopulateList();
            string output = "";
            int response = -1;
            while (response != 0)
            {
                Console.WriteLine("Enter number of function to run \n0. Exit \n1. Order vehicles by age in descending order \n2. Order vehicles alphabetically by make \n3. Order vehicles by cost \n4. Order vehicles by consumer value \n5. Calculate fuel consumption for miles driven \n6. Pick a random car \n7. See average MPG by year");
                try
                {
                    response = Convert.ToInt32(Console.ReadLine());
                }
                
                catch (FormatException)
                {
                    output = "Why would you use a letter?";
                }

                switch (response)
                {
                    case 1:
                        output = methods.GetNewest(list);
                        break;
                    case 2:
                        output = methods.GetAlphabeticOrder(list);
                        break;
                    case 3:
                        output = methods.GetOrderByPrice(list);
                        break;
                    case 4:
                        output = methods.OrderByValue(list);
                        break;
                    case 5:
                        Console.WriteLine("Enter Distance");
                        int mileage = Convert.ToInt32(Console.ReadLine());
                        output = methods.CalculateFuelConsumption(list, mileage);
                        break;
                    case 6:
                        // output = list.RandomElement().Model;
                        output = methods.GetRandomCar(list);
                        break;
                    case 7:
                        output = methods.AverageMPGByYear(list);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(output);
                Console.WriteLine("\n");
            }
        }
    }
    public static class ColectionExtension
    {
        private static Random rand = new Random();

        public static T RandomElement<T>(this IList<T> list)
        {
            return list[rand.Next(list.Count)];
        }

    }
}
