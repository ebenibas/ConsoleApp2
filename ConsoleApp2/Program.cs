using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string newWord = "Trying Trying to remove duplicate words words.";
            string letter = RemoveDuplicateChars("loovert");

            Console.WriteLine("Before removing duplicates");
            Console.WriteLine(newWord);

            Console.WriteLine("After removing duplicates");
            Console.WriteLine(RemoveDuplicateWords(newWord));


            Console.WriteLine(letter);
            Console.ReadLine();
        }

        static public string RemoveDuplicateWords(string v)
        {
            // save the words
            var wordstorage = new Dictionary<string, bool>();

            StringBuilder sb = new StringBuilder();

            //Take care of spaces and punctuation.
            string[] a = v.Split(new char[] { ' ', ',', ';', '.' },
                StringSplitOptions.RemoveEmptyEntries);

            // Loop over each word
            foreach (string current in a)
            {
                //convert to lowercase
                string lower = current.ToLower();


                // display in result if a new word
                if (!wordstorage.ContainsKey(lower))
                {
                    sb.Append(current).Append(' ');
                    wordstorage.Add(lower, true);
                }
            }


            return sb.ToString().Trim();
        }

        static string RemoveDuplicateChars(string key)
        {

            // Save the words
            string wordstorage = "";

            // save the result.
            string result = "";

            // Loop over each character.
            foreach (char c in key)
            {
                // See if character is in the table.
                if (wordstorage.IndexOf(c) == -1)
                {
                    // Append to the table and the result.
                    wordstorage += c;
                    result += c;
                }
            }
            return result;
        }
    }

}
