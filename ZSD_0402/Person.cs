using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSD_0402
{
    class Person
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public Person(string line)
        {
            string[] temp = line.Split('-');
            Height = int.Parse(temp[0]);
            Weight = int.Parse(temp[1]);
        }
        public Person(int Height, int Weight)
        {
            this.Height = Height;
            this.Weight = Weight;
        }
    }
}
