using System;
using System.Collections.Generic;

namespace Animal_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var _animals = new List<Animal>();
            var _dogs = new List<Dog>();
            var _usererrors = new List<UserError>();
            _usererrors.Add(new NumericInputError());
            _usererrors.Add(new TextInputError());
            _usererrors.Add(new AnimalError());
            _usererrors.Add(new PersonError());
            _usererrors.Add(new DogError());

            foreach (UserError userError in _usererrors)
            {
               Console.WriteLine(userError.UEMessage());
               Console.WriteLine("");
            }

//test
            _animals.Add(new Horse("Molly", 500, 15, 55));
            _animals.Add(new Dog("Milton", 5, 8, "Labrador"));
            _animals.Add(new Hedgehog("Sonic", 0.8, 1, 3000));
            _animals.Add(new Worm("Dagge", 0.02, 0.5, true));
            _animals.Add(new Bird("Valle", 0.05, 3, 10));
            _animals.Add(new Pelikan("Pelle", 1.5, 6, 65));
            _animals.Add(new Flamingo("Dirdre", 1, 2, 100));
            _animals.Add(new Swan("Cygnus olor", 10, 5, 2.4));
            _animals.Add(new Wolf("Petter", 45, 0.5, 3));
            _animals.Add(new Wolfman("Jack", 95, 55, 2));

            //_dogs.Add(new Horse("Molly", 500, 15, 55)); Cannot convert from Animal Dof to Horse


            foreach (var animal in _animals)
            {
                if (animal is Wolfman)
                {
                    Wolfman wolfman = (Wolfman)animal;
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine($"The sound of { wolfman.GetType().Name} is" + $" {wolfman.Talk()}");
                    Console.WriteLine("");

                }
                else if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine(dog.TestDog());
                    Console.WriteLine($"The sound of { animal.GetType().Name} is" + $" {animal.DoSound()}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine($"The sound of { animal.GetType().Name} is" + $" {animal.DoSound()}");
                    Console.WriteLine("");

                }

            }

            //Console.WriteLine($"{horse.Name} weight: {horse.Weight} age: {horse.Age}");
            //Console.WriteLine($"The sound of { horse.GetType().Name} is" +
            //    $" {horse.DoSound()}");

            Console.ReadKey();
        }
    }
}
