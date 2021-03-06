﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kata.sortingitout
{
    public class CharacterSorter
    {
        public static string Sort(string input)
        {
            var characterCount = new Dictionary<char, int>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                characterCount.Add(i, 0);
            }

            var inputLowerCase = input.ToLower();

            for (int i = 0; i < inputLowerCase.Length; i++)
            {
                var character = inputLowerCase[i];
                if (character >= 'a' && character <= 'z')
                {
                    characterCount[character]++;
                }
            }

            var builder = new StringBuilder(input.Length);
            foreach (var keyValuePair in characterCount.OrderBy(x => x.Key))
            {
                var character = keyValuePair.Key;
                var count = keyValuePair.Value;
                builder.Append(character, count);
            }
            return builder.ToString();
        }
    }
}
