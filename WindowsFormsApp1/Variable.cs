using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class Variable
    {
        public Variable(char name)
        {
            Name = name.ToString();
            Vars = new List<bool> { };
        }
        public Variable(string name)
        {
            Name = name;
            Vars = new List<bool> { };
        }
        public Variable(Variable vars)
        {
            Name = vars.Name;
            List<bool> temp = new List<bool> { };
            temp.AddRange(vars.Vars);
            Vars = temp;
        }
        public Variable Negation()
        {
            Variable temp = new Variable(this);
            temp.Name = $"¬ {temp.Name}";
            if (temp.Name.StartsWith("¬ ¬ "))
            {
                temp.Name = temp.Name.Remove(0, 4);
            }
            for (int i = 0; i < temp.Vars.Count; i++)
            {
                temp.Vars[i] = !temp.Vars[i];
            }
            return temp;
        }
        public Variable Conjunction(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " ∧ ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(Vars[i] && other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable Disjunction(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " ∨ ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(Vars[i] || other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable Implication(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " → ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(!Vars[i] || other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable Converse(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " ← ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(Vars[i] || !other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable Equivalent(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " ↔ ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(Vars[i] == other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable ExclusiveDisjunction(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " ⊕ ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(Vars[i] != other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable NotAnd(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " | ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(!Vars[i] || !other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public Variable NotOr(Variable other)
        {
            Variable v = new Variable(MakeName(Name, " ↓ ", other.Name));
            List<bool> temp = new List<bool> { };
            for (int i = 0; i < Vars.Count; i++)
            {
                temp.Add(!Vars[i] && !other.Vars[i]);
            }
            v.Vars = temp;
            return v;
        }
        public string Name { get; set; }
        public List<bool> Vars { get; set; }
        public void SetVars(int index, int size)
        {
            Vars = new List<bool> { };
            int switcherCounter = 0;
            bool switcher = false;
            for (int i = 0; i < Pow2(size); i++)
            {
                if (switcherCounter < Pow2(size - index - 1))
                {
                    switcherCounter++;
                }
                else
                {
                    switcher = !switcher;
                    switcherCounter = 1;
                }
                Vars.Add(switcher);
            }
        }
        private string MakeName(string first, string operation, string second)
        {
            return first + operation + second;
        }
        private int Pow2(int power)
        {
            return 1 << power;
        }
    }
}
