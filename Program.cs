/*
 * Author: Gursimran Kaur
 * Course: COMP003A
 * Purpose: COMP003A.Assignment7
 */

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Character Counter Section
            SectionSeparator("Array Character Counter Section");
            Console.Write("Enter a single letter: ");
            char userCharInput = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a word: ");
            string userWordInput = Console.ReadLine();

            int charCount = CharacterCounter(userCharInput, userWordInput);
            SectionSeparator("Array Character Counter Section");

            Console.WriteLine($"Character '{userCharInput}' occurs {charCount} times in the word '{userWordInput}'\n");

            // Array-IsPalindrome Section
            SectionSeparator("Array-IsPalindrome Section");
            Console.Write("Enter a word: ");
            string userPalindromeInput = Console.ReadLine();

            bool isPalindrome = IsPalindrome(userPalindromeInput);
            SectionSeparator("Array-IsPalindrome Section");

            Console.WriteLine($"The word '{userPalindromeInput}' is {(isPalindrome ? "a palindrome" : "not a palindrome")}\n");

            // List Add Section
            SectionSeparator("List Add Section");

            List<string> names = new List<string>();
            char userInput = default;

            do
            {
                Console.Write("Enter a name (or 'exit' to stop): ");
                string enteredName = Console.ReadLine();

                if (enteredName.ToLower() == "exit")
                    break;

                names.Add(enteredName);

            } while (true);

            SectionSeparator("List Add Section");

            // Traverselist Section
            SectionSeparator("Traverse List");
            TraverseList(names);

            // TraverseListReverse Section
            SectionSeparator("Traverse List in Reverse");
            TraverseListReverse(names);
        }

        static void SectionSeparator(string sectionName)
        {
            Console.WriteLine($"-------- {sectionName} --------");
        }

        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;

            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsPalindrome(string word)
        {
            string reversedWord = "";
            word = word.ToLower();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return word == reversedWord;
        }

        static void TraverseList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
