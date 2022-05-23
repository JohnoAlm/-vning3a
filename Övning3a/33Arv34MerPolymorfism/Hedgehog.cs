using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class Hedgehog : Animal
    {
        public int SpikeSharpness { get; set; }
        public Hedgehog(string name, double weight, int age, int spikeSharpness) : base(name, weight, age)
        {
            SpikeSharpness = spikeSharpness;
        }

        public override string DoSound()
        {
            return "Mipipipipimipiiiiiiiiiipi...Mipipipipipip.Mippipipipipipi";
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nTaggvasshet: {SpikeSharpness} %";
        }
    }
}
