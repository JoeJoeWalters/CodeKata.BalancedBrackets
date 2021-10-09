using System;
using System.Collections.Generic;

namespace Core
{

    public class BracketBucket
    {
        private KeyValuePair<string, int> Left;
        private KeyValuePair<string, int> Right;
    }

    public class BalancedBracketsChecker
    {
        private List<char> validBrackets = new List<char>() {'{', '}', '(', ')', '[', ']'};

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
            foreach (char key in validBrackets)
            {
                if (testString.Contains(key))
                    bracketBucket[key]++;
            }

            return (bracketBucket['{'] == bracketBucket['}'] &&
                bracketBucket['('] == bracketBucket[')'] &&
                bracketBucket['['] == bracketBucket[']']);
        }
    }
}
