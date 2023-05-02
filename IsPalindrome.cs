// A simple program to check if the user's inputted string is palindrome or not by ignoring whitespace, case and punctuation.

namespace IsPalindrome
{
    class IsPalindrome
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string.");
            string input = "";
            while (true)
            {
                #pragma warning disable CS8600  // To disable C# CS8600 warning
                input = Console.ReadLine();
                if (input == "exit")
                {
                    return;
                }
                #pragma warning disable CS8604
                var tuble = isPalindrome(input);
                System.Console.WriteLine($"Palindrome: {tuble.Item1}, Length: {tuble.Item2}");
            }
        }
        static Tuple<bool, int> isPalindrome(string input)
        {
            bool isPalindrome = false;
            int stringLength = input.Length;
            string trimmed = input.Replace(" ", "");
            string lower = trimmed.ToLower();
            string output = lower;
            string puncRemoved = "";
            foreach (char c in output)
            {
                if (!char.IsPunctuation(c))
                {
                    puncRemoved += c;
                }
            }
            string reversed = "";
            for (int i = puncRemoved.Length - 1; i >= 0 ; i--)
            {
                reversed += puncRemoved[i];
            }
            if (puncRemoved == reversed)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
                stringLength = 0;
            }
            return new Tuple<bool, int>(isPalindrome, stringLength);
        }
    }
}
