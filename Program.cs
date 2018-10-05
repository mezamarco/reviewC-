using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }
        public string name;
        //We will have a static variable
        static int numOfAnimals = 0;
        //We also need a static function
        public static int getAnimalCount()
        {
            return numOfAnimals;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Default Constructor
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No name";
            this.sound = "No sound";
            ++numOfAnimals;
        }


        //Custom Constructor
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            ++numOfAnimals;
        }


        //All our Animal functions
        public string toString()
        {
            return String.Format("{0} is {1} inches, weight: {2} lbs, sound : {3}",
                                    name, height, weight, sound);
        }


        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");
            Animal spotty = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine(spot.toString());

            //Access our static variable
            Console.WriteLine("Number of Animals: " + Animal.getAnimalCount() + "\n\n");
            Console.ReadLine();
        }

    }


    class Dog : Animal
    {


    }

}
