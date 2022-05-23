using Övning3a._33Arv;
using System;

namespace Övning3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3.1) Inkapsling

            ////3.1) Inkapsling

            //try
            //{

            //    Console.WriteLine("Mata in förnamn: ");
            //    string fName = Console.ReadLine();

            //    Console.WriteLine("Mata in efternamn: ");
            //    string lName = Console.ReadLine();

            //    Console.WriteLine("Mata in ålder: ");
            //    string age = Console.ReadLine();

            //    int ageValue;
            //    int.TryParse(age, out ageValue);

            //    Console.WriteLine("Mata in längd: ");
            //    string height = Console.ReadLine();

            //    double heightValue;
            //    double.TryParse(height, out heightValue);

            //    Console.WriteLine("Mata in vikt: ");
            //    string weight = Console.ReadLine();

            //    double weightValue;
            //    double.TryParse(weight, out weightValue);

            //    Person personWithInput = new Person(ageValue, fName, lName, heightValue, weightValue);
            //    personWithInput.DisplayPerson();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //var person = PersonHandler.CreatePerson(37, "Lewis", "Hamilton", 174, 73);
            //Console.WriteLine("\n");
            //person.DisplayPerson();

            //// Sätter personens födelsedag
            //PersonHandler.SetBirthDay(person, 1985, 1, 7);


            //var person2 = PersonHandler.CreatePerson(132, "Dwight D.", "Eisenhower", 179, 78);
            //Console.WriteLine("\n");
            //person2.DisplayPerson();

            //// Sätter personens födelsedag
            //PersonHandler.SetBirthDay(person2, 1890, 10, 14);


            //var person3 = PersonHandler.CreatePerson(526, "Gustav", "Vasa", 173, 89);
            //Console.WriteLine("\n");
            //person3.DisplayPerson();

            //// Sätter personens födelsedag
            //PersonHandler.SetBirthDay(person3, 1496, 5, 12);


            //Console.WriteLine("\n");
            //PersonHandler.SetAge(person3, 1000);
            //person3.DisplayPerson();

            //Console.ReadLine();

            #endregion

            #region 3.2) Polymorfism

            //// 3.2) Polymorfism

            //// Skapar en lista av UserError som heter userErrors
            //List<UserError> userErrors = new List<UserError>();

            //// Lägger in instanser av NumericInputError och TextInputError men även DivideByZeroInputError, NumberToBigInputError
            //userErrors.Add(new NumericInputError());
            //userErrors.Add(new TextInputError());
            //// Instanser av de egna klasserna
            //userErrors.Add(new DivideByZeroInputError());
            //userErrors.Add(new NumberToBigInputError());
            //userErrors.Add(new FileNotFoundInputError());

            //foreach (UserError error in userErrors)
            //{
            //    var userErrorMessage = error.UEMessage();
            //    Console.WriteLine(userErrorMessage);
            //}

            //Console.ReadLine();

            #endregion

            #region 3.3) Arv 

            // 3.3) Arv

            #region Frågor
            /* 
              Fråga 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver
              ett nytt attribut, i vilken klass bör vi lägga det?

              Svar: Vi kan lägga det attributet i klassen Bird.cs eftersom att fåglarna 
              Pelican, Flamingo och Swan alla ärver från denna klass.
            */

            /*
              Fråga 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?

              Svar: Man skulle kunna lägga det i Animal.cs klassen eftersom att det är bas-klassen
              alla djur oavsätt Häst, Hund eller Svan härstammar (ärver) från bas-klassen Animals
              och detta gör också alla dessa subklasser till animals.
            */
            #endregion

            #endregion

            #region 3.4) Mer polymorfism

            // 3.4) Mer polymorfism

            Animal bird = new Bird("Koltrast", 0.1, 1, 100);
            Animal flamingo = new Flamingo("Flamingo", 0.2, 2, 0, true);
            Animal dog = new Dog("Pluto", 4.5, 3, 100);
            Animal horse = new Horse("Frank", 380, 5, 70);
            Animal swan = new Swan("Micke", 3, 3, 0, false);
            Animal doggo = new Dog("Doggo", 3.6, 5, 50);


            List<Animal> animals = new List<Animal>();
           
            animals.Add(bird);
            animals.Add(flamingo);
            animals.Add(dog);
            animals.Add(horse);
            animals.Add(swan);
            animals.Add(doggo);
            // Skriver ut alla djur i listan
            Console.WriteLine("\nSkriver ut alla djur i listan: ");
            foreach (Animal animal in animals)
            {
                // Skriver ut samtliga animal stats
                var res = animal.Stats();

                Console.WriteLine(res);
                // Skriver ut animal sound

                var resSound = animal.DoSound();
                Console.WriteLine(resSound);

                // Type-Castar till IPerson och anropar Talk() metoden
                if(animal is IPerson)
                {
                    IPerson animalIperson  = (IPerson)animal;
                    var result = animalIperson.Talk();
                    Console.WriteLine(result);                    
                }

                // Här använder vi oss av Type-Cast för att skriva ut den unika Dog metoden i listan av animals
                if (animal is Dog)
                {
                    Dog dogSpecialMethod = (Dog)animal;
                    var resultat = dogSpecialMethod.ReturneraValfriSträng();
                    Console.WriteLine(resultat);
                }

            }
            Console.WriteLine("_____________________________________________");

            // Skriver ut enbart för alla hundar i animals
            // Här specificerar vi att vi bara vill skriva ut typen Dog i vår animals lista genom "OfType<TResult>"
            Console.WriteLine($"\nSkriver ut enbart hundarna i listan: ");
            
            foreach (Animal animal in animals.OfType<Dog>())
            {
                var res = animal.Stats();
                Console.WriteLine(res);
            }
            
            Animal dogRudolph = new Dog("Rudolph", 4.5, 3, 100);
            Animal dogButch = new Dog("Butch", 4.5, 3, 100);
            Animal dogFredrik = new Dog("Fredrik", 4.5, 3, 100);

            // Skapar en lista av hundar // Ändras till typ "Animal" så att alla klasser ska kunna lagras tillsammans
            List<Animal> dogList = new List<Animal>();

            dogList.Add(dogRudolph);
            dogList.Add(dogButch);
            dogList.Add(dogFredrik);

            

            Console.ReadLine();

            #region Frågor

            // Fråga 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?

            /* Svar: Detta fungerar inte eftersom att vi har skapat en lista av hundar. En hund är ett djur men om vi har 
            en lista av specifikt hundar så kan vi inte skapa en Animal referens till hund objektet och lägga den i listan.
            Den måste peka till just en hund.
            
            Samma gäller för hästen. Hästen är ett djur precis som en hund men en häst är självklart ingen hund. Därav kan vi
            alltså inte lägga till en häst i en lista som bara tar emot hund objekt. */

            // Fråga 10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?

            /* Svar: Listan måste vara av typen Animal för att alla klasser skall kunna lagras tillsammans. Detta eftersom att i detta
               fall så är Animal basklassen eller föräldern. */

            // Fråga 13. F: Förklara vad det är som händer.
               
            /* Svar: Det vi gör är att vi använder foreach loopen för att loopa igenom alla objekt i vår lista av Animals. Sedan
               inuti denna loop så anropar vi metoden Stats() för alla objekt i listan som vi lagrar i variabeln res. Slutligen
               skriver vi ut res genom en helt vanlig Console.WriteLine();*/

            // Fråga 17. F: Varför inte?
            /* Svar: Jag kommer inte åt den nya metoden "ReturneraValfriSträng()" eftersom att den är unik till Dog klassen och
               gäller alltså bara för endast hundar. Därför kan vi inte komma åt den metoden från animals listan. */
            

            #endregion

            #endregion













        }
    }
}
