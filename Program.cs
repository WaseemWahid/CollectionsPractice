using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main()
        {
            // THREE BASIC ARRAYS
            // Create an array to hold integer values 0 through 9
            int[] array1;
            array1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int idx = 0; idx < array1.Length; idx++)
            {
                Console.WriteLine($"Arrays from {array1[idx]}");
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[] { "Tim", "Marting", "Nikki", "Sara" };
            foreach (string name in names)
            {
                Console.WriteLine($"The name is {name}");
            }

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] arr = new bool[10];
            arr[0] = true;
            arr[1] = false;
            arr[2] = true;
            arr[3] = false;
            arr[4] = true;
            arr[5] = false;
            arr[6] = true;
            arr[7] = false;
            arr[8] = true;
            arr[9] = false;
            foreach (bool result in arr)
            {
                Console.WriteLine($"That is {result}");
            }
            // LIST OF FLAVORS
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Mint Cholcolate Chip");
            flavors.Add("Rocky Road");
            flavors.Add("Strawberry");
            // Output the length of this list after building it
            Console.WriteLine($"We currently offer {flavors.Count} flavors!");
            // Output the third flavor in the list, then remove this value
            // Output the new length of the list (It should just be one fewer!)
            for (var i = 0; i < flavors.Count; i++)
            {
                Console.WriteLine("-" + flavors[i]);
            }
            Console.WriteLine("We are running low on " + flavors[2]);
            Console.WriteLine("We ran out of some flavors here is the updated flavor menu!");
            flavors.Remove(flavors[2]);
            foreach (string update in flavors)
            {
                Console.WriteLine("-" + update);
            }
            // USER INFO DICTIONARY
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> profile = new Dictionary<string, string>();
                        // Add key/value pairs to this dictionary where:
                // each key is a name from your names array
                // each value is a randomly select a flavor from your flavors list.
            foreach (var name in names)
            {
                profile.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in names)
            {
                int randInx = rand.Next(flavors.Count);
                profile[name] = flavors[randInx];
                flavors.RemoveAt(randInx);
            }
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in profile)
            {
                Console.WriteLine("{0}'s choice for flavor is {1}", entry.Key, entry.Value);
            }
        }
    }
}
