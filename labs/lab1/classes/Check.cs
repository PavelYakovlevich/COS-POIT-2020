using System;

namespace lab1
{
    class Check
    {
        public static bool IsFloatValue(string text)
        {
            if (text == null || text == "") return false;
            if (!char.IsDigit(text[0])) return false;

            for(int i = 1; i < text.Length-1; i++)
            {
                if (!char.IsDigit(text[i]) && text[i] != '.') return false;
            }

            return char.IsDigit(text[text.Length - 1]);
        }
    }
}