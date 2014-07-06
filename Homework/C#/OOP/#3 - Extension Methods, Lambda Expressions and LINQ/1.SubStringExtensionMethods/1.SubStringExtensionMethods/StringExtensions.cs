namespace ExtensionMethods
{
    using System;
    using System.Text;

    public static class StringExtensions
    {
        public static string SubStr(this string newString, int index, int length)
        {
            var result = new StringBuilder();

            for (int i = index - 1; i <= length - 1; i++)
            {
                result.Append(newString[i]);
            }

            return result.ToString();
        }
    }
}
