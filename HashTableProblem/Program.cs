using System;
using System.Linq;


namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable Program\n");

            // Convert phrase to string array using split method
            string temp = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] samplephrase = temp.ToLower().Split(" ");
            
            // get only distinct elements
            var phrase = samplephrase.Distinct();

            // calculate length of distinct variable
            int length = 0;
            foreach (var item in phrase){ length++; }

            // Object of MyHashNode class
            MyHashNode<string, int> hash = new MyHashNode<string, int>(length);


            // Add each string into HashTable and determine frequency
            int count = 1;
            foreach (string word in samplephrase)
            {
                if (hash.ContainsKey(word))
                {
                    count = hash.GetValue(word) + 1;
                    hash.Remove(word);
                    hash.Add(word, count);
                }
                else
                {
                    hash.Add(word, 1);
                }
            }


            // Print the result
            Console.WriteLine($"{"Frequency", 20} | {"Count", 10}\n");
            foreach (string key in phrase)
            {
                Console.WriteLine($"{key, 20} | {hash.GetValue(key), 10}");
            }

        }
    }
}
