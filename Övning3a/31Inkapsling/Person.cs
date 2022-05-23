using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// HahaAhhhaHAhAhAAhAhAhAhahahahahaHAHAHAHA!!!! Du löste det!!! Yeeeesssss!
namespace Övning3a 
{
    internal class Person
    {
        // Privata fält
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        private DateTime birthDay;

        // Publika properties
        public int Age
        {
            get { return age; }

            set
            {
                if (value < 0) 
                { 
                    throw new ArgumentException("Fel imatning. Ålder måste vara större än 0. Försök igen."); 
                }
                
                else 
                { 
                    age = value;
                }
            }
        }
        public string FName
        {
            get { return fName; }

            set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException("Fel inmatning. Förnamn får inte vara mindre än 2 tecken långt. Försök igen");
                }
                else if(value.Length > 10)
                {
                    throw new ArgumentException("Fel inmatning. Förnamn får inte vara mer än 10 tecken långt. Försök igen.");
                }
                else
                {
                    fName = value;
                }
                
            }
        }
        public string LName
        {
            get { return lName; }

            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Fel inmatning. Efternamn får inte vara mindre än 3 tecken långt. Försök igen.");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Fel inmatning. Efternamn får inte vara mer än 15 tecken långt. Försök igen.");
                }
                else
                {
                    lName = value;
                }
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }

        public DateTime BirthDay { get; set; }

        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Namn: {FName} {LName} \nÅlder: {Age} år\nLängd: {Height} cm\nVikt: {Weight} kg");
        }

    }
}
