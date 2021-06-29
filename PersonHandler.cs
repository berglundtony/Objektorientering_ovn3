using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering_ovn3
{
    public class PersonHandler 
    {
        private List<Person> _personhandler;

        public PersonHandler()
        {
            _personhandler = new List<Person>();
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            _personhandler.Add(new Person(age, fname, lname, height, weight));
        }

        public Person[] GetPersons()
        {
            return _personhandler.ToArray();
        }
    }
}
