using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARaces
{
    public delegate void CarEventHandler();
    public abstract class Car
    {
        public event CarEventHandler Finish;
        
        public string Name { get; set; }
        public int TopSpeed { get; set; }
        public int Distance { get; set; }
        public abstract void Drive();
    }
}
