using System.Text;

namespace C_Home_Work
{
    internal class String
    {
        static void Main(string[] args)
        {
            //********************************************TASK1********************************************
            //string str = "Hello";
            //string str1 = "World";
            //int position = 3;
            //string result = str.Insert(position, str1);
            //Console.WriteLine(result);
            ////********************************************TASK2********************************************
            //string text = "Hello World!";
            //int totalChars = text.Length;
            //int lowerCaseCount = 0;
            //int upperCaseCount = 0;
            //foreach (char c in text)
            //{
            //    if (char.IsLower(c))
            //    {
            //        lowerCaseCount++;
            //    }
            //    else if (char.IsUpper(c))
            //    {
            //        upperCaseCount++;
            //    }
            //}
            //double lowerCasePercentage = (double)lowerCaseCount / totalChars * 100;
            //double upperCasePercentage = (double)upperCaseCount / totalChars * 100;

            //Console.WriteLine("Total characters: " + totalChars);
            //Console.WriteLine("Lowercase letters count: " + lowerCaseCount);
            //Console.WriteLine("Uppercase letters count: " + upperCaseCount);
            //Console.WriteLine("Percentage of lowercase letters: " + lowerCasePercentage + "%");
            //Console.WriteLine("Percentage of uppercase letters: " + upperCasePercentage + "%");
            ////********************************************TASK4********************************************
            //string[] words = { "car", "apple", "flat", "house", "numbers" };
            //int chosenLength = 6;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length == chosenLength)
            //    {
            //        words[i] = words[i].Substring(0, words[i].Length - 3) + "$";
            //    }
            //}
            //Console.WriteLine("Modified words array : ");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //********************************************TASK5********************************************
            //Console.Write("Enter the text: ");
            //string inputText = Console.ReadLine();

            //Console.Write("Enter the word position (starting from 1): ");
            //if (int.TryParse(Console.ReadLine(), out int wordPosition))
            //{
            //    string[] words = inputText.Split(' ');

            //    if (wordPosition > 0 && wordPosition <= words.Length)
            //    {
            //        string word = words[wordPosition - 1];
            //        char firstLetter = word[0];
            //        Console.WriteLine($"The first letter of word at position {wordPosition} is: {firstLetter}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Word position is out of range");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for word position");
            //}
            //********************************************TASK6********************************************
            //Console.Write("Enter the string of words: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string result = string.Join("*", words);
            //Console.WriteLine("Modified string: " + result);
            //********************************************TASK7********************************************
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter words (enter a word ending with   .   to finish):");
            while (true)
            {
                Console.Write("Word : ");
                string word = Console.ReadLine().Trim();

                if (word.EndsWith("."))
                {
                    break;
                }

                sb.Append(word);
                sb.Append(", ");
            }
            if (sb.Length > 0)
            {
                sb.Length -= 2;
            }
            string result = sb.ToString();
            Console.WriteLine($"Resulting string: {result}");

        }
    }
}
