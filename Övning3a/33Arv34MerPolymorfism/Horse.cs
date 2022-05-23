using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class Horse : Animal
    {
        public int GallopingSpeed { get; set; }
        public Horse(string name, double weight, int age, int gallopingSpeed) : base(name, weight, age)
        {
            GallopingSpeed = gallopingSpeed;
        }

        public override string DoSound()
        {
            return "NEIGHHHHH!!";
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nGalopperingsfart: {GallopingSpeed} km/h";
        }
    }
}
