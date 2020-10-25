using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ex_14_william
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPText = "";
            string singleKey = "";
            var Key = "";
            Console.WriteLine("Welcome to Simple Chipher exercise\n" +
                "\nPlease enter the string you want to encrypt: ");
            inputPText = Console.ReadLine();
            do
            {
                Console.WriteLine("\nPlease provide a key of an alphabetic character: ");
                singleKey = Console.ReadLine();
            } while (!char.IsLetter(singleKey[0]) | singleKey.Length > 1 );
            do
            {
                Console.WriteLine("Please provide a key only contain alphabetic characters: ");
                Key = Console.ReadLine();
            } while (!Key.All(char.IsLetter));

            Cipher cipher = new Cipher();
            string result1 = cipher.SimpleCipher(singleKey[0], inputPText);
            string result2 = cipher.LessSimpleCipher(Key, inputPText);
            string result3 = cipher.StillLessSimpleCipher(Key, inputPText);

            Console.WriteLine($"\nThe Plain text is [{inputPText}] \n" +
                $"\nSimple Cipher: The encrypted message is [{result1}] \n" +
                $"Less Simple Cipher: The encrypted message is [{result2}] \n" +
                $"Still Less Simple Cipher: The encrypted message is [{result3}] \n"
                );
            Console.WriteLine();
        }
    }

    public class Cipher
    {
        public Dictionary<char, int> dict1 = new Dictionary<char, int>();
        public Cipher()
        {
            char charKey = 'A';
            for (int i = 1; i <= 26; i++)
            {
                dict1.Add(charKey, i);
                charKey++;
            }
        }

        //65 % 65 = 0 + 65

        public string SimpleCipher(char key, string input)
        {
            key = char.ToUpper(key);
            input = input.ToUpper();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char newChar = (char)(char.ToUpper(input[i]) + dict1[key]);
                    result += newChar.ToString();
                }
            }
            return result;
        }

        public string LessSimpleCipher(string key, string input)
        {
            string result = "";
            key = key.ToUpper();
            input = input.ToUpper();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char newChar = (char)(char.ToUpper(input[i]) + dict1[key[counter % 3]]);
                    result += newChar.ToString();
                    counter++;
                }
            }
            return result;
        }

        public string StillLessSimpleCipher(string key, string input)
        {
            
            string newKey = key.ToUpper() + input.ToUpper();
            string finalKey = "";

            for (int i = 0; i < newKey.Length; i++)
            {
                if (char.IsLetter(newKey[i]))
                {
                    finalKey += newKey[i];
                }
            }
            
            int num = 0;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char newChar;
                    if (char.ToUpper((char)(input[i] + dict1[finalKey[num]]))>90)
                    {
                        newChar = (char)(char.ToUpper(input[i]) + dict1[finalKey[num]] - 26);
                    }
                    else
                        newChar = (char) (char.ToUpper(input[i]) + dict1[finalKey[num]]);

                    result += newChar.ToString();
                    num++;
                }
            }
            // we at
            // ca tw
            // dict[w] = 23, t = 84, newChar = 107. 
            // 107 - 26 = 81
            return result;
        }
    }
}
