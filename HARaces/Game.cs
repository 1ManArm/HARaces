using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARaces
{
    public class Game
    {
        public void Start() 
        {
            Sports sports = new Sports() {TopSpeed = 10, Distance = 0 };
            Saloon saloon = new Saloon() { TopSpeed = 6, Distance = 0 };
            Van van = new Van() {  TopSpeed = 4, Distance = 0 };
            Bus bus = new Bus() {  TopSpeed = 3, Distance = 0 };

            sports.Finish += () =>
            {
                Console.WriteLine("Спорткар доехал до финиша!");
            };
            saloon.Finish += () =>
            {
                Console.WriteLine("Легковой автомобиль доехал до финиша!");
            };
            van.Finish += () =>
            {
                Console.WriteLine("Фургон доехал до финиша!");
            };
            bus.Finish += () =>
            {
                Console.WriteLine("Автобус доехал до финиша!");
            };

            int countSec = 1;
            Console.WriteLine("seconds\t\tsports\tsaloon\tvan\tbus");
            Console.WriteLine("-----------------------------------");
            while(true)
            {
                sports.Drive();
                saloon.Drive();
                van.Drive();
                bus.Drive();
                Console.WriteLine("{0}\t\t{1}m\t\t{2}m\t\t{3}m\t\t{4}m", countSec++, sports.Distance, saloon.Distance, van.Distance, bus.Distance);

                if(sports.Distance >= 100 || saloon.Distance >= 100 || van.Distance >= 100 || bus.Distance >= 100)
                {
                    break;
                }
            }
        }
    }
}
