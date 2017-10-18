using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEiSystems
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public float TCC { get; set; }
        public int MPG { get; set; }
       
        public List<Car> PopulateList()
        {
            var cars = new List<Car>
            {
                new Car {Make="Honda", Model = "CRV", Color="Green", Year = 2016, Price = 23845, TCC = 8, MPG = 33 },
                new Car {Make="Ford", Model = "Escape", Color="Red", Year = 2017, Price = 23590, TCC = 7.8f, MPG = 32 },
                new Car {Make="Hyundai", Model = "Santa", Color="Gray", Year = 2016, Price = 24950, TCC = 8, MPG = 27 },
                new Car {Make="Mazda", Model = "CX-5", Color="Red", Year = 2017, Price = 21795, TCC = 8, MPG = 35 },
                new Car {Make="Subaru", Model = "Frstr", Color="Blue", Year = 2016, Price = 22395, TCC = 8.4f, MPG = 32 }
            };

            return cars;
        }

    }


}
