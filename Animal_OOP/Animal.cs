using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_OOP
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }

        public abstract string DoSound();

        public Animal(string name, double weight, double age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
        }

        public virtual string Stats()
        {
            return $"Name: {Name} Weight: {Weight} Age: {Age}";
        }

    }

    public class Horse : Animal
    {
        public double Speed { get; set; }
        public Horse(string name, double weight, double age, double speed) : base(name, weight, age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.Speed = speed;
        }
        public override string DoSound()
        {
            return ("Neigh");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Speed: {Speed} km/h";
        }

    }

    public class Dog : Animal, IDog
    {
        public string BreedOfDog { get; set; }
        public Dog(string name, double weight, double age, string breedofdog) : base(name, weight, age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.BreedOfDog = breedofdog;
        }
        public override string DoSound()
        {
            return ("Wow wow");
        }

        public override string Stats()
        {
            return $" {base.Stats()} Breed: {BreedOfDog}";
        }

        public string TestDog()
        {
            return ("Test dog");
        }
    }

    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, double weight, double age, int numberofspikes) : base(name, weight, age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.NrOfSpikes = numberofspikes;
        }

        public override string DoSound()
        {
            return ("Growl");
        }

        public override string Stats()
        {
            return $" {base.Stats()} Number of Spikes: {NrOfSpikes}";
        }
    }

    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, double age, bool ispoisonous) : base(name, weight, age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.IsPoisonous = ispoisonous;
        }

        public override string DoSound()
        {
            return ("A loud pop");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Is poisonous: {IsPoisonous}";
        }
    }

    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, double age, double wingspan) : base(name, weight, age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.WingSpan = wingspan;
        }

        public override string DoSound()
        {
            return ("Tweet tweet");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Wingspan: {WingSpan}";
        }
    }

    public class Pelikan : Bird
    {
        public Pelikan(string name, double weight, double age, double wingspan) : base(name, weight, age, wingspan)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.WingSpan = wingspan;
        }

        public override string DoSound()
        {
            return ("Dok");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Wing span: {WingSpan}";
        }
    }

    public class Flamingo : Bird
    {
        public Flamingo(string name, double weight, double age, double wingspan) : base(name, weight, age, wingspan)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.WingSpan = wingspan;
        }

        public override string DoSound()
        {
            return ("Quack quack");
        }

        public override string Stats()
        {
            return $" {base.Stats()} Wingspan: {WingSpan}";
        }
    }



    public class Swan : Bird
    {
        public Swan(string name, double weight, double age, double wingspan) : base(name, weight, age, wingspan)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.WingSpan = wingspan;
        }

        public override string DoSound()
        {
            return ("oh-oh oh-oh");
        }

        public override string Stats()
        {
            return $" {base.Stats()} Wing span: {WingSpan}";
        }
    }

    public class Wolf : Animal
    {
        public int PuppyLitter { get; set; }
        public Wolf(string name, double weight, double age, int puppylitter) : base(name, weight, age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.PuppyLitter = puppylitter;
        }

        public override string DoSound()
        {
            return ("Howl");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Puppy Litter: {PuppyLitter}";
        }
    }

    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, double age, int puppylitter) : base(name, weight, age, puppylitter)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.PuppyLitter = puppylitter;
        }

        public string Talk()
        {
            return "I'm a wolfman. I looks like a wolf, but I can talk.";
        }

        public override string Stats()
        {
            return $"{base.Stats()} Puppy litter: {PuppyLitter}";
        }
    }



}
