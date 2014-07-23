namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalTest
    {
        static void Main()
        {
            var dog = new Dog();
            //Console.WriteLine(dog);
            //Console.WriteLine(dog.Greet());

            var cat = new Cat();
            //Console.WriteLine(cat.Greet());

            var snake = new Snake();
            //Console.WriteLine(snake.Greet());

            var animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(snake);
            animals.Add(new Dog());
            animals.Add(new Dog());

            var collectionOfDogs = animals.OfType<Dog>().Cast<Dog>();

            foreach (var item in collectionOfDogs)
            {
                //item.Run();
            }

            foreach (var item in animals)
            {
                //Console.WriteLine(item);
                int legs = item.GetNumberOfLegs();
                Console.WriteLine(item.GetType().Name + " " + legs);
            }

            try
            {
                cat.Name = "buksi";
            }
            catch (InvalidAnimalNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
