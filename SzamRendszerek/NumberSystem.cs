using System;
using System.Collections.Generic;
using System.Text;

namespace SzamRendszerek
{
    public class NumberSystem
    {
        private static char[] _chars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                                                    'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private static Dictionary<char, int> _dict;

        public static void Init()
        {
            _dict = new Dictionary<char, int>();

            for (int x = 0; x < _chars.Length; x++)
            {
                _dict.Add(_chars[x], x);
            }
        }

        public static int GetNumberValue(char c)
        {
            if (_dict.ContainsKey(c))
                return _dict[c];

            return 0;
        }

        public static char GetCharacterValue(int i)
        {
            if (_dict.ContainsValue(i))
                return GetKeyByValue(i);

            return '0';
        }

        private static char GetKeyByValue(int i)
        {
            foreach (KeyValuePair<char, int> pair in _dict)
            {
                if (pair.Value == i)
                    return pair.Key;
            }

            return '0';
        }

        public static bool CheckNumber(string number, int system)
        {
            for (int x = 0; x < number.Length; x++)
            {
                if (!SystemContainsLetter(number[x], system))
                    return false;
            }

            return true;
        }

        public static bool SystemContainsLetter(char c, int system)
        {
            return (_dict[c] < system);
        }
    }
}
