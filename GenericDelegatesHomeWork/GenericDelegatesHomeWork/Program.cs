using System;

namespace GenericDelegatesHomeWork
{
    class Program
    {
        static Func<int, int, int, string> Numbers = (num1, num2, num3) =>
            {
                if (num1 < num2 && num1 < num3) { return $"{num1} is the smallest number"; }
                else if (num2 < num3 && num2 < num1) { return $"{num2} is the smallest number"; }
                else { return $"{num3} is the smallest number"; }


            };
        static Action<int, int, int> Numbers2 = (num1, num2, num3) =>
          {
              Console.WriteLine((num1 + num2 + num3) / 3);
          };
        static Action<string> Chars = (Word) =>
        {
            if (Word.Length % 2 == 1)
            {
                Console.WriteLine($"the middle character in the string:{Word[((Word.Length - 1) / 2) + 1]}");
            }
            else
            {
                Console.WriteLine($"the middle character in the string:{Word[(Word.Length / 2) - 1]}{Word[Word.Length / 2]}");
            }
        };
        static Action<string> Vowels = (word) =>
        {
            int Vowel = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        Vowel++;
                        break;
                    default:
                        break;


                }
            }
            Console.WriteLine($"number of  vowels in the string:{Vowel}");
        };
        static Action<string> WordsNumber = (Sentence) =>
        {
            int words = 1;
            foreach (var Char in Sentence)
            {
                switch(Char)
                {
                    case ' ':
                        words++;
                    break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"number of words in the string: {words}");
        };
        static Action<int> DigitSum = (Number) =>
         {
             int digits = 0;
             foreach (var digit in Number.ToString())
             {
                 digits += Convert.ToInt32(digit.ToString());
             }
             Console.WriteLine($"sum { digits}");
         };  
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(25, 37, 29));
            Numbers2(25, 45, 65);
            Chars("efraim");
            Vowels("w3resource");
            WordsNumber("Daniel wants to kill or Ganon");
            DigitSum(25);

            
        }
    }
}
