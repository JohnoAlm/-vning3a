using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a._33Arv
{
    internal class Flamingo : Bird
    {
        public bool IsPink { get; set; }
        public Flamingo(string name, double weight, int age, int singingSkillLevel, bool isPink) : base(name, weight, age, singingSkillLevel)
        {
            IsPink = isPink;
        }

        public override string Stats()
        {
            return $"\nNamn: {Name}\nVikt: {Weight} kg\nÅlder: {Age} år\nÄr rosa?: {IsPink}";
        }
    }
}
