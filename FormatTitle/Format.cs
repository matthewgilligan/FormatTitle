using System;
using System.Text;

namespace FormatTitle
{
    public class Format
    {
        public string DoIt(string title, bool preserveAcronyms)
        {
            if (title.Contains("_"))
            {
                return title.Replace("_", " ");
            }
            else
            {
                var newTitle = new StringBuilder(title.Length * 2);

                newTitle.Append(title[0]);

                for (int i = 1; i < title.Length; i++)
                {
                    if (char.IsUpper(title[i]))
                        if ((title[i - 1] != ' ' && !char.IsUpper(title[i - 1])) ||
                            (preserveAcronyms && char.IsUpper(title[i - 1]) &&
                            i < title.Length - 1 && !char.IsUpper(title[i + 1])))
                            newTitle.Append(' ');
                    newTitle.Append(title[i]);
                }

                return newTitle.ToString();
            }
        }
    }
}
