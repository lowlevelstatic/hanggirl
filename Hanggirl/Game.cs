using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanggirl
{
    class Game
    {
        Random rnd = new Random();
        private readonly Book book = new Book();
        private String currentWord;

        public void Start()
        {
            Console.WriteLine("Welcome to hanggirl!");
            int wordnumber = rnd.Next(0, book.Length);
            currentWord = book.GetString(wordnumber);
            int spaces = currentWord.Length;
            HashSet<char> correctGuesses = new HashSet<char>();
            HashSet<char> incorrectGuesses = new HashSet<char>();

            while (true)
            {
                for (int index = 0; index < spaces; ++index)
                {
                    if (correctGuesses.Contains(currentWord.ElementAt(index)))
                    {
                        Console.Write(currentWord.ElementAt(index) + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }

                if (incorrectGuesses.Count >= 1)
                {
                    Console.Write("\n================");
                    Console.Write("\n||             |");
                }
                if (incorrectGuesses.Count >= 2)
                {
                    Console.Write("\n||             |");
                    Console.Write("\n||             |");
                }
                if (incorrectGuesses.Count >= 3)
                {
                    Console.Write("\n||            ____");
                    Console.Write("\n||           /    \\");
                    Console.Write("\n||           \\____/");
                }
                if (incorrectGuesses.Count >= 4)
                {
                    Console.Write("\n||            /||\\");
                    Console.Write("\n||          /  ||  \\");
                    Console.Write("\n||         /   ||    \\");
                }
                if (incorrectGuesses.Count >= 5)
                {
                    Console.Write("\n||             /\\");
                    Console.Write("\n||            /  \\");
                }
                if (incorrectGuesses.Count >= 6)
                {
                    Console.Write("\n||           /    \\");
                    Console.Write("\n||          /      \\");
                }
                if (incorrectGuesses.Count >= 7)
                {
                    Console.Write("\n||" +
                    "\n||" +
                    "\n||");
                }
                if (incorrectGuesses.Count >= 8)
                {
                    Console.Write("\n||" +
                    "\n============");
                }

                if (AllLettersGuessed(currentWord, correctGuesses))
                {
                    Console.WriteLine("\nCongratulations! You completed the word.");
                    break;
                }

                Console.WriteLine("\nPlease try to guess a letter in the word.");

                Console.WriteLine("You have " + incorrectGuesses.Count.ToString() + " incorrect guesses.");

                var entry = Console.ReadLine();

                try
                {
                    if (entry.Length != 1 || !Char.IsLetter(entry.ElementAt(0)))
                    {
                        Console.WriteLine("Please enter a single letter.");
                        continue;
                    }

                    char guessedLetter = entry.ElementAt(0);

                    if (correctGuesses.Contains(guessedLetter) || incorrectGuesses.Contains(guessedLetter))
                    {
                        Console.WriteLine("You have already guessed that letter");
                    }
                    else if (currentWord.Contains(guessedLetter))
                    {
                        Console.WriteLine("Correct.");
                        correctGuesses.Add(guessedLetter);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                        incorrectGuesses.Add(guessedLetter);
                    }
                }
                catch (Exception)
                {

                }

            }
            // Loop until game over
            // Show current game state (welcome, guessed word, gallows, guessed letters, prompt)
            // Get entry from player
            // Check for valid input - 1 character, character is a letter, character not already guessed, etc.
            // Check for correct/incorrect guess
            // Refresh screen/end loop
        }

        private static bool AllLettersGuessed(String currentWord, HashSet<char> guesses)
        {
            foreach (char letter in currentWord)
            {
                if (!guesses.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
