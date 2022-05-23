using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class Worm : Animal
    {
        public bool IsSlimey { get; set; }
        public Worm(string name, double weight, int age, bool isSlimey) : base(name, weight, age)
        {
            IsSlimey = isSlimey;
        }

        public override string DoSound()
        {
            return "sssssslimmeeyyyyyyy??";
        }

         public override string Stats()
         {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nÄr slajmig?: {IsSlimey}";
         }
    }
}
