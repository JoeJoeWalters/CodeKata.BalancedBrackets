using System;
using System.Collections.Generic;

namespace Core
{
    public class BalancedBracketsChecker
    {
        private Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            {'{', '}' },
            {'(', ')' },
            {'[', ']' }
        };

        public BalancedBracketsChecker()
        {
        }

        public Boolean Test(string testString)
        {
            Stack<char> expectedCloses = new Stack<char>();

            foreach (char character in testString)
            {
                if (pairs.ContainsKey(character))
                {
                    expectedCloses.Push(pairs[character]);
                }
                else
                {
                    char expectedCharacter = expectedCloses.Pop();
                    if (character != expectedCharacter) return false;
                }
            }

            return true;
        }
    }
}
