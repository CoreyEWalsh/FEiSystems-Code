using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEiSystems
{
    public class CarMethods
    {
        public string GetNewest(List<Car> input)
        {
            string output = "Make\t Model\t Year\t Color\t Price\t TCC\t MPG\n";
            var newList = input.OrderByDescending(car => car.Year).ToList();
            foreach (Car o in newList)
            {
                output += (String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\n", o.Make, o.Model, o.Year, o.Color, o.Price, o.TCC, o.MPG));
            }
            return output;
        }

        public string GetAlphabeticOrder(List<Car> input)
        {
            string output = "Make\t Model\t Year\t Color\t Price\t TCC\t MPG\n";
            var newList = input.OrderBy(car => car.Make).ToList();
            foreach (Car o in newList)
            {
                output += (String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\n", o.Make, o.Model, o.Year, o.Color, o.Price, o.TCC, o.MPG));
            }
            return output;
        }

        public string GetOrderByPrice(List<Car> input)
        {
            string output = "Make\t Model\t Year\t Color\t Price\t TCC\t MPG\n";
            var newList = input.OrderBy(car => car.Price).ToList();
            foreach (Car o in newList)
            {
                output += (String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\n", o.Make, o.Model, o.Year, o.Color, o.Price, o.TCC, o.MPG));
            }
            return output;
        }

       
        public string OrderByValue(List<Car> input)
        {
            string output = "Make\t Model\t Year\t Color\t Price\t TCC\t MPG\n";
            var newList = input.OrderByDescending(car => car.TCC).ThenBy(car => car.Price).ToList();
            foreach (Car o in newList)
            {
                output += (String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\n", o.Make, o.Model, o.Year, o.Color, o.Price, o.TCC, o.MPG));
            }
            return output;
        }

        public string CalculateFuelConsumption(List<Car> input, int miles)
        {
            string output = String.Format("Make\t Model\t Gallons for {0} miles\n", miles);
            var newList = input.OrderByDescending(Car => GallonsConsumed(miles, Car.MPG));
            foreach (Car o in newList)
            {
                output += (String.Format("{0}\t {1}\t {2}\n", o.Make, o.Model, GallonsConsumed(miles, o.MPG)));
            }
            return output;
        }
        public double GallonsConsumed(int miles, int mpg)
        {
            return Math.Round(((double)miles / mpg), 2);
        }

        public string AverageMPGByYear(List<Car> input)
        {
            double average2017 = 0.0, average2016 = 0.0;
            string output;

            average2017 = Math.Round(input.Where(o => o.Year == 2017).Average(i => i.MPG), 2);
            average2016 = Math.Round(input.Where(o => o.Year == 2016).Average(i => i.MPG), 2);

            return output = String.Format("2017 Models average {0} MPG\n2016 models average {1} MPG", average2017, average2016);

        }

        public string GetRandomCar(List<Car> input)
        {
            string output = "Make\t Model\t Year\t Color\t Price\t TCC\t MPG\n";
            Random rand = new Random();
            int rInt = rand.Next(0, input.Count);
            var item = input.ElementAt(rInt);
            return output += (String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\n", item.Make, item.Model, item.Year, item.Color, item.Price, item.TCC, item.MPG));
        }
    }
}
