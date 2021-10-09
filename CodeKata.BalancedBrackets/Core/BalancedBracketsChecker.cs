using System;
using System.Collections.Generic;

namespace Core
{
    public class BalancedBracketsChecker
    {
        private List<char> validBrackets = new List<char>() {'{', '}', '(', ')', '[', ']'};
        private Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            {'{', '}' },
            {'(', ')' },
            {'[', ']' }
        };

        private Dictionary<Char, int> bracketBucket = new Dictionary<char, int>()
        {
            {'{', 0},
            {'}', 0},
            {'(', 0},
            {')', 0},
            {'[', 0},
            {']', 0},
        };

        public BalancedBracketsChecker()
        {
        }

        public Boolean Test(string testString)
        {
            // Stage 1
            /*
            foreach (char key in validBrackets)
            {
                if (testString.Contains(key))
                    bracketBucket[key]++;
            }

            return (bracketBucket['{'] == bracketBucket['}'] &&
                bracketBucket['('] == bracketBucket[')'] &&
                bracketBucket['['] == bracketBucket[']']);
            */

            // Stage 2
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
