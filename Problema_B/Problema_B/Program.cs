using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            Console.WriteLine("Escreva uma frase");
            string text = Console.ReadLine().ToLower();
            int vowels = 0, consonants = 0;

            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine($"Temos {vowels} vogais e {consonants} consoantes");
        }
    }
}