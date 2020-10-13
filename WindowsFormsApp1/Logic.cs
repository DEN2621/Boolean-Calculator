using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Logic
    {
        private static List<string> AVAILABLE_NAME_OF_VARS = new List<string> { };
        private static SortedDictionary<string, string> BINARY_OPERATIONS = new SortedDictionary<string, string> { };
        private static SortedDictionary<string, int> BINARY_OPERATIONS_CODES = new SortedDictionary<string, int> { };
        private static ContentEditor ce;
        private static SortedDictionary<string, int> map = new SortedDictionary<string, int> { };
        private static List<string> variables = new List<string> { };
        private static List<Variable> vars = new List<Variable> { };
        public Logic(TextBox output, DataGridView outTable)
        {
            variables = new List<string> { };
            vars = new List<Variable> { };
            ce = new ContentEditor(output, outTable);
            map = new SortedDictionary<string, int> { };
        }
        public static void Compute()
        {
            ComputeLogicalAction(variables);
            ce.PrintTruthTable(VarsTitle, VarsData);
        }
        public static void ComputeLogicalAction(List<string> v)
        {
            FindBrackets(v);
            Negation(v);
            BinaryOperation(v, "∧");
            BinaryOperation(v, "∨");
            BinaryOperation(v, "|");
            BinaryOperation(v, "↓");
            BinaryOperation(v, "→");
            BinaryOperation(v, "⊕");
            BinaryOperation(v, "←");
            BinaryOperation(v, "↔");
        }
        public static List<string> VarsTitle
        {
            get
            {
                List<string> result = new List<string> { };
                for (int i = 0; i < vars.Count; i++)
                {
                    result.Add(vars[i].Name);
                }
                return result;
            }
        }
        public static List<List<bool>> VarsData
        {
            get
            {
                List<List<bool>> result = new List<List<bool>> { };
                for (int i = 0; i < vars.Count; i++)
                {
                    result.Add(vars[i].Vars);
                }
                return result;
            }
        }
        public static void MakeSDNF()
        {
            if (vars.Count != 0)
            {
                string ans = "";
                int num = vars[0].Vars.Count;
                int degree = 0;
                while (num != 1)
                {
                    degree++;
                    num /= 2;
                }
                List<bool> truthTable = vars.Last().Vars;
                for (int i = 0; i < truthTable.Count; i++)
                {
                    if (truthTable[i])
                    {
                        ans += "( ";
                        for (int j = 0; j < degree; j++)
                        {
                            ans += vars[j].Vars[i] ? vars[j].Name : $"¬ {vars[j].Name}";
                            ans += j + 1 != degree ? " ∧ " : "";
                        }
                        ans += " ) ∨ ";
                    }
                }
                if (ans.Length != 0)
                {
                    ans = ans.Remove(ans.LastIndexOf('∨'));
                }
                ce.PrintSDNF(ans);
            }
        }
        public static void MakeSKNF()
        {
            if (vars.Count != 0)
            {
                string ans = "";
                int num = vars[0].Vars.Count;
                int degree = 0;
                while (num != 1)
                {
                    degree++;
                    num /= 2;
                }
                List<bool> truthTable = vars.Last().Vars;
                for (int i = 0; i < truthTable.Count; i++)
                {
                    if (!truthTable[i])
                    {
                        ans += "( ";
                        for (int j = 0; j < degree; j++)
                        {
                            ans += vars[j].Vars[i] ? $"¬ {vars[j].Name}" : vars[j].Name;
                            ans += j + 1 != degree ? " ∨ " : "";
                        }
                        ans += " ) ∧ ";
                    }
                }
                if (ans.Length != 0)
                {
                    ans = ans.Remove(ans.LastIndexOf('∧'));
                }
                ce.PrintSKNF(ans);
            }
        }
        public static void SetVars(List<string> v)
        {
            variables = v;
            FillOperations();
            FillVars();
            SortVars();
            FillMap();
            MakeBoolArrays();
        }
        private static void BinaryOperation(List<string> v, string operation)
        {
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == operation
                        && i + 1 != v.Count && i - 1 != -1
                        && map.ContainsKey(v[i + 1]) && map.ContainsKey(v[i - 1]))
                {
                    Variable newVar = new Variable("NULL");
                    switch (BINARY_OPERATIONS_CODES[BINARY_OPERATIONS[operation]])
                    {
                        case 1: newVar = GetVariable(v[i - 1]).Conjunction(GetVariable(v[i + 1])); break;
                        case 2: newVar = GetVariable(v[i - 1]).Disjunction(GetVariable(v[i + 1])); break;
                        case 3: newVar = GetVariable(v[i - 1]).Implication(GetVariable(v[i + 1])); break;
                        case 4: newVar = GetVariable(v[i - 1]).Converse(GetVariable(v[i + 1])); break;
                        case 5: newVar = GetVariable(v[i - 1]).Equivalent(GetVariable(v[i + 1])); break;
                        case 6: newVar = GetVariable(v[i - 1]).ExclusiveDisjunction(GetVariable(v[i + 1])); break;
                        case 7: newVar = GetVariable(v[i - 1]).NotAnd(GetVariable(v[i + 1])); break;
                        case 8: newVar = GetVariable(v[i - 1]).NotOr(GetVariable(v[i + 1])); break;
                        default: break;
                    }
                    InsertWithReplace(v, newVar, i - 1, i + 1);
                    --i;
                }
            }
        }
        private static void FillMap()
        {
            map.Clear();
            for (int i = 0; i < vars.Count; ++i)
            {
                map.Add(vars[i].Name, i);
            }
        }
        private static void FillOperations()
        {
            BINARY_OPERATIONS["∧"] = "conjunction";
            BINARY_OPERATIONS["∨"] = "disjunction";
            BINARY_OPERATIONS["⊕"] = "exclusiveDisjunction";
            BINARY_OPERATIONS["|"] = "notAnd";
            BINARY_OPERATIONS["↓"] = "notOr";
            BINARY_OPERATIONS["→"] = "implication";
            BINARY_OPERATIONS["←"] = "converse";
            BINARY_OPERATIONS["↔"] = "equivalent";
            BINARY_OPERATIONS_CODES["conjunction"] = 1;
            BINARY_OPERATIONS_CODES["disjunction"] = 2;
            BINARY_OPERATIONS_CODES["implication"] = 3;
            BINARY_OPERATIONS_CODES["converse"] = 4;
            BINARY_OPERATIONS_CODES["equivalent"] = 5;
            BINARY_OPERATIONS_CODES["exclusiveDisjunction"] = 6;
            BINARY_OPERATIONS_CODES["notAnd"] = 7;
            BINARY_OPERATIONS_CODES["notOr"] = 8;
            AVAILABLE_NAME_OF_VARS = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I",
                                                         "G", "K", "L", "M", "N", "O", "P", "Q", "R",
                                                         "S", "T", "U", "V", "W", "X", "Y", "Z", "a",
                                                         "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                                         "k", "l", "m", "n", "o", "p", "q", "r", "s",
                                                         "t", "u", "v", "w", "x", "y", "z" };
        }
        private static void FillVars()
        {
            vars.Clear();
            for (int i = 0; i < variables.Count; i++)
            {
                char c = variables[i][0];
                if (AVAILABLE_NAME_OF_VARS.IndexOf(variables[i]) != -1 && !IsRepeat(c))
                {
                    vars.Add(new Variable(variables[i][0]));
                }
            }
        }
        private static void FindBrackets(List<string> v)
        {
            List<int> bracket_ind = new List<int> { };
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == "(")
                {
                    bracket_ind.Add(i);
                }
                if (v[i] == ")" && bracket_ind.Count > 0)
                {
                    List<string> new_v = SubString(v, bracket_ind.Last() + 1, i - 1);
                    ComputeLogicalAction(new_v);
                    for (int n = bracket_ind.Last(); n <= i; n++)
                    {
                        v.RemoveAt(bracket_ind.Last());
                    }
                    string new_name = $"({new_v[0]})";
                    v.Insert(bracket_ind.Last(), new_name);
                    map[new_name] = map[new_v[0]];
                    vars[map[new_name]].Name = new_name;
                    i = bracket_ind.Last();
                    bracket_ind.RemoveAt(bracket_ind.Count - 1);
                }
            }
        }
        private static Variable GetVariable(string name)
        {
            return map.ContainsKey(name) ? new Variable(vars[map[name]]) : new Variable("NULL");
        }
        private static void InsertWithReplace(List<string> v, Variable variable, int begin, int end)
        {
            if (!map.ContainsKey(variable.Name))
            {
                vars.Add(variable);
                map[variable.Name] = vars.Count - 1;
            }
            for (int i = begin; i <= end; i++)
            {
                v.RemoveAt(begin);
            }
            v.Insert(begin, variable.Name);
        }
        private static bool IsRepeat(char c)
        {
            for (int i = 0; i < vars.Count; i++)
            {
                if (vars[i].Name == c.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private static void MakeBoolArrays()
        {
            int length = vars.Count;
            for (int i = 0; i < length; i++)
            {
                vars[i].SetVars(i, length);
            }
        }
        private static void Negation(List<string> v)
        {
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == "¬" && i + 1 != v.Count && map.ContainsKey(v[i + 1]))
                {
                    Variable newVar = GetVariable(v[i + 1]).Negation();
                    if (newVar.Name != "NULL")
                    {
                        InsertWithReplace(v, newVar, i, i + 1);
                    }
                }
            }
        }
        private static void SortVars()
        {
            for (int i = 0; i < vars.Count - 1; i++)
            {
                for (int j = i + 1; j < vars.Count; j++)
                {
                    if (string.Compare(vars[i].Name, vars[j].Name) > 0)
                    {
                        string c = vars[i].Name;
                        vars[i].Name = vars[j].Name;
                        vars[j].Name = c;
                    }
                }
            }
        }
        private static List<string> SubString(List<string> v, int begin, int end)
        {
            List<string> new_v = new List<string> { };
            do
            {
                new_v.Add(v[begin]);
            }
            while (begin++ < end);
            return new_v;
        }
    }
}