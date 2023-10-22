using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARaces
{
    public class Sports : Car
    {
        public event CarEventHandler Finish;
        public string Name { get; set; }
        public int TopSpeed { get; set; }
        public int Distance { get; set; }
        private Random rand;
        public Sports()
        {
            rand = new Random();
        }
        public override void Drive()
        {
            int distancePerSec = rand.Next(1, TopSpeed);
            Distance += distancePerSec;

            if(Distance >= 100) 
            {
                Finish();
            }
        }
    }
}
