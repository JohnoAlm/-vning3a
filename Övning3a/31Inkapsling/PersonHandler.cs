using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class PersonHandler
    {
        
        public static Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person(age, fName, lName, height, weight);
            return person;
            
        }

        public static void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        /* Kanske finns bättre sätt att sätta en födelsedag på men detta funkade så jag körde på det här.
         Först specificerar man vilken person det är, sedan skriver man in år, månad, dag som sedan matas in
         i ett nytt DateTime objekt hos den personen. Sen är det bara att skriva ut det.*/
        public static void SetBirthDay(Person pers, int year, int month, int day)
        {
            pers.BirthDay = new DateTime(year, month, day);
            Console.WriteLine($"Födelsedag: {pers.BirthDay.ToShortDateString()}");
        }


    }
}
