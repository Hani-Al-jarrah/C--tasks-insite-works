﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_solving_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string word = Console.ReadLine().ToLower(); 
            int vowelCount = CountVowels(word);
            Console.WriteLine(vowelCount);
        }

        static int CountVowels(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++) 
            {
    
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
            }
            return count; 
        }
    }


}

