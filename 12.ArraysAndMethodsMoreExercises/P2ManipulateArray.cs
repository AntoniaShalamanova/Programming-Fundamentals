using System;
using System.Linq;

namespace P2ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            int comandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < comandsNumber; i++)
            {
                string[] comandParams = Console.ReadLine().Split(' ');

                if (comandParams[0] == "Reverse")
                {
                    ReverseArray(words);
                }
                else if (comandParams[0] == "Distinct")
                {
                    DeleteRepeatingWords(words);
                }
                else if (comandParams[0] == "Replace")
                {
                    int indx = int.Parse(comandParams[1]);
                    string replacingWord = comandParams[2];

                    ReplaceWord(words, indx, replacingWord);
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "")
                {
                    continue;
                }
                if (i == words.Length - 1)
                {
                    Console.WriteLine(words[i]);
                }
                else
                {
                    Console.Write(words[i] + ", ");
                }

            }
        }

        static void ReplaceWord(string[] words, int indx, string replacingWord)
        {
            words[indx] = replacingWord;
        }

        static void DeleteRepeatingWords(string[] words)
        {
            int arrayLength = words.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == arrayLength - 1)
                {
                    continue;
                }
                else
                {
                    for (int j = i + 1; j < arrayLength; j++)
                    {
                        if (words[i] == words[j])
                        {
                            for (int k = j; k < arrayLength; k++)
                            {
                                if (k == arrayLength - 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    words[k] = words[k + 1];
                                }
                            }

                            words = words.Where((val, indx) => indx != words.Length - 1).ToArray();
                        }
                    }
                }
            }
        }

        static void ReverseArray(string[] words)
        {
            for (int i = 0; i < words.Length / 2; i++)
            {
                string currentWord = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = currentWord;
            }
        }
    }
}
