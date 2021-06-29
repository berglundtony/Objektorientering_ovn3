using System;

namespace Objektorientering_ovn3
{
    class Program
    {
        static PersonHandler personhandler = new PersonHandler();
      
        static void Main(string[] args)
        {
            SeedData();
            Person[] persons = personhandler.GetPersons();

            foreach(Person person in persons)
            {
                Console.WriteLine($"Ålder: {person.Age} \r\n Förnamn: {person.fName} \r\n Efternamn: {person.lName} \r\n Längd: {person.Height} \r\n Vikt: {person.Weight}");
            }
            //Person pers = new Person();
            //personhandler.SetAge(pers, 56);

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            Console.ReadKey();
        }

        private static void SeedData()
        {
            try
            {
                personhandler.CreatePerson(20, "Sigvard", "Haraldsson", 1.85, 85.3);
                personhandler.CreatePerson(32, "Gudrun", "Svensson", 1.65, 70.8);
                personhandler.CreatePerson(55, "Hedvig", "Emundsson", 1.75, 77.5);
                personhandler.CreatePerson(-2, "D", "Al", 1.60, 70.5);
            }
            catch (ArgumentException aex)
            {
                throw new ArgumentException(aex.Message);
            }
        
        }
    }
}
