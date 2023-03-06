using System;

namespace GenericAnimalClass
{
    public class Animal<T>
    {
        private T data;

        public Animal(T data)
        {
            this.data = data;
        }

        public T getAnimal()
        {
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Sea Turtle");
            Animal<string> animalHabitat = new Animal<string>("Ocean");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(15);

            Console.WriteLine("Animal Name: " + animalName.getAnimal());
            Console.WriteLine("Habitat: " + animalHabitat.getAnimal());
            Console.WriteLine("Endangered: " + endangered.getAnimal());
            Console.WriteLine("Extinct: " + extinct.getAnimal());
            Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal() + " years");
        }
    }
}
