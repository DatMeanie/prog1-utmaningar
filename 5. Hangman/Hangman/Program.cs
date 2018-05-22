using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static string RandomWord()
        {
            string[] wordList = new string[10];
            wordList[0] = "kush";
            wordList[1] = "meme";
            wordList[2] = "bad";
            wordList[3] = "ugh";
            wordList[4] = "hentai";
            wordList[5] = "afghanistan";
            wordList[6] = "mlg";
            wordList[7] = "feelsbadman";
            wordList[8] = "herpes";
            wordList[9] = "eatdog";
            Random rnd = new Random();
            int randomWord = rnd.Next(0, wordList.Count());
            return wordList[randomWord];

        }
        static void Main(string[] args)
        {
            Console.WriteLine("hangman game\n");
            while(0 != 69) //game started
            {
                char[] guessCharacters = RandomWord().ToCharArray();
                string[] lines = new string[guessCharacters.Count()];
                for(int i = 0; i < guessCharacters.Count(); i++)
                {
                    lines[i] = "_ ";
                }
                for (int tries = 5; tries > 0; tries--)
                { //guess one word
                    foreach(string line in lines)
                    {
                        Console.Write(line);
                    }
                    Console.WriteLine("\nyou got " + tries + " tries left");
                    string guess = Console.ReadLine();
                    try
                    {
                        char result = Convert.ToChar(guess);
                        bool a = Array.Exists(guessCharacters, element => element == result); //is guess in the word?
                        if (a == true) 
                        {
                            tries++;
                            for(int i = 0; i < guessCharacters.Count(); i++)
                            {
                                if(guessCharacters[i] == result)
                                {
                                    lines[i] = $"{guess} ";
                                    if(Array.Exists(lines, element => element == "_ ") == false)
                                    {
                                        Console.WriteLine(guessCharacters);
                                        Console.WriteLine("Congratulations! You guessed the word!");
                                        tries -= 69; //no tries, the game resets
                                    }
                                }
                            }
                        }
                    }
                    catch(Exception)
                    {

                    }
                }
            }
        }
    }
}
