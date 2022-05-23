using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class Wolf : Animal
    {
        public int HowlLevel { get; set; }
        public Wolf(string name, double weight, int age, int howlLevel) : base(name, weight, age)
        {
            HowlLevel = howlLevel;
        }

        public override string DoSound()
        {
            return "AAAAOOOOOOOOOOOOOOOOOOOAWWHOOAOAOWHOAOWHOOOOOOOOOOOOOOOOOOOOOOOOOWHOOO!!!!!!";
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nYlnivå: lvl{HowlLevel}";
        }
    }
}
