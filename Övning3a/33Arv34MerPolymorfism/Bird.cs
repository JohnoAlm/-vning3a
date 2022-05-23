using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    
    internal class Bird : Animal
    {
        public int SingingSkillLevel { get; set; }
        public Bird(string name, double weight, int age, int singingSkillLevel) : base(name, weight, age)
        {
            SingingSkillLevel = singingSkillLevel;
        }

        public override string DoSound()
        {
            return "Pi..pipipi..pipipi...pipippipipipip.pippipi";
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nSångskicklighet: {SingingSkillLevel} %";
        }
    }
}
