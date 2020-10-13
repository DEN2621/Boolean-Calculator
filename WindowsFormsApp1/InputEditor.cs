using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class InputEditor
    {
        public static List<string> AVAILABLE_WORDS = new List<string> { };
        public static SortedDictionary<string, string> AVAILABLE_TRANSFORMATIONS = new SortedDictionary<string, string> { };
        public InputEditor()
        {
            Vars = new List<string>();
            FillConsts();
        }
        public static List<string> Vars { get; set; }
        public static bool Parse(string str)
        {
            List<int> errors = new List<int> { };
            string[] sl = Regex.Split(str.Trim(' '), "\\s");
            for (int i = 0; i < sl.Length; i++)
            {
                if (AVAILABLE_WORDS.IndexOf(sl[i]) == -1)
                {
                    errors.Add(i);
                }
            }
            if (errors.Count == 0)
            {
                Vars.Clear();
                for (int i = 0; i < sl.Length; i++)
                {
                    Vars.Add(sl[i]);
                }
            }
            else
            {
                string msg = "Неправильный синтаксис: ";
                for (int i = 0; i < errors.Count; i++)
                {
                    msg += $"\"{sl[errors[i]][i]}\"";
                }
                MessageBox.Show(msg, "Ошибка");
                return false;
            }
            return true;
        }
        private static void FillConsts()
        {
            AVAILABLE_WORDS = new List<string>() { "∧", "∨", "¬", "⊕", "→", "←", "↔", "|", "↓",
                                                 "A", "B", "C", "D", "E",  "F",  "G", "H", "I",
                                                 "G", "K", "L", "M", "N",  "O",  "P", "Q", "R",
                                                 "S", "T", "U", "V", "W",  "X",  "Y", "Z", "a",
                                                 "b", "c", "d", "e", "f",  "g",  "h", "i", "j",
                                                 "k", "l", "m", "n", "o",  "p",  "q", "r", "s",
                                                 "t", "u", "v", "w", "x",  "y",  "z", "(", ")" };
            AVAILABLE_TRANSFORMATIONS["conjunction"] = "∧";
            AVAILABLE_TRANSFORMATIONS["disjunction"] = "∨";
            AVAILABLE_TRANSFORMATIONS["exclusive_disjunction"] = "⊕";
            AVAILABLE_TRANSFORMATIONS["not_and"] = "|";
            AVAILABLE_TRANSFORMATIONS["not_or"] = "↓";
            AVAILABLE_TRANSFORMATIONS["implication"] = "→";
            AVAILABLE_TRANSFORMATIONS["converse"] = "←";
            AVAILABLE_TRANSFORMATIONS["equivalent"] = "↔";
            AVAILABLE_TRANSFORMATIONS["negation"] = "¬";
        }
    }
}
