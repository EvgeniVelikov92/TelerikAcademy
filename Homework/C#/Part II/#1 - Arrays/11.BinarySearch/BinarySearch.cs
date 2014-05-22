// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Pachycephalosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nSort");
            dinosaurs.Sort();

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nBinarySearch and Insert \"Coelophysis\":");
            int index = dinosaurs.BinarySearch("Coelophysis");
            if (index < 0)
            {
                dinosaurs.Insert(~index, "Coelophysis");
            }

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nBinarySearch and Insert \"Tyrannosaurus\":");
            index = dinosaurs.BinarySearch("Tyrannosaurus");
            if (index < 0)
            {
                dinosaurs.Insert(~index, "Tyrannosaurus");
            }

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
        }
    }
}
