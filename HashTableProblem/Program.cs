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
            string[] samplephrase = "To be or not to be".ToLower().Split(" ");
            
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
            Console.WriteLine($"Frequency of \"to\" is {hash.GetValue("to")}");
        }
    }
}
