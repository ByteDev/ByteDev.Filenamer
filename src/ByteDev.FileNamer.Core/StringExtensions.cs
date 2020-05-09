using System.Text.RegularExpressions;

namespace ByteDev.FileNamer.Core
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a copy of the string with each word as a capital
        /// (rest of word is made lowercase)
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToCapitalCase(this string source)
        {
            int cursorPos = 0;
            bool isInWord = false;

            string text = source.ToLower();

            while (cursorPos < text.Length)
            {
                string cursorChar = text.Substring(cursorPos, 1);

                if (IsIgnoreChar(cursorChar))
                {
                    isInWord = false;
                    cursorPos++;
                    continue;
                }

                if (!isInWord)
                {
                    var reg = new Regex("[A-Za-z]");
                    Match m = reg.Match(cursorChar);

                    if (m.Success)
                    {
                        text = text.Substring(0, cursorPos) + cursorChar.ToUpper() + text.Substring(cursorPos + 1);
                    }
                    isInWord = true;
                }
                cursorPos++;
            }

            return text;            
        }

        private static bool IsIgnoreChar(string c)
        {
            return ((c == " ") ||
                    (c == "\t") ||
                    (c == "\r") ||
                    (c == "\n") ||
                    (c == "(") ||
                    (c == ")") ||
                    (c == "[") ||
                    (c == "]") ||
                    (c == "."));
        }
    }
}
