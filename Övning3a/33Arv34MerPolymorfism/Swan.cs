using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a._33Arv
{
    internal class Swan : Bird
    {
        public bool IsAnUglyDuckling { get; set; }
        public Swan(string name, double weight, int age, int singingSkillLevel, bool isAnUglyDuckling) : base(name, weight, age, singingSkillLevel)
        {
            IsAnUglyDuckling = isAnUglyDuckling;
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nÄr en ful ankunge?: {IsAnUglyDuckling}";
        }
    }
}
