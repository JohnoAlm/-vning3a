using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a._33Arv
{
    internal class Pelican : Bird
    {
        public int BeekSize { get; set; }
        public Pelican(string name, double weight, int age, int singingSkillLevel, int beekSize) : base(name, weight, age, singingSkillLevel)
        {
            BeekSize = beekSize;
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nNäbbstorlek: {BeekSize} cm";
        }
    }
}
