using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class Dog : Animal
    {
        public int BarkPower { get; set; }
        public Dog(string name, double weight, int age, int barkPower) : base(name, weight, age)
        {
            BarkPower = barkPower;
        }

        public override string DoSound()
        {
            return "WOOF! WOOF! WOOFWOOF! WOOOF!";
        }
        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nSkallkraft: {BarkPower} %";
        }

        public string ReturneraValfriSträng()
        {
            return "Skriver ut en valfri sträng... (Detta är den speciella Dog metoden).";
        }
    }
}
