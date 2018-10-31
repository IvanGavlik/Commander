using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.model
{
    public class Grammar
    {
        private List<String> GrammarRules;

        public Grammar()
        {
            GrammarRules = new List<String>();
        }

        public bool addGrammarRule(String rule)
        {
            String oldRule = GrammarRules.Find(r => r.Equals(rule));
            if (oldRule == null)
            {
                GrammarRules.Add(rule);
            }
            {
                return false;
            }

        }

        public List<String> Rules
        {
            get
            {
                return this.GrammarRules;
            }
        }
    }
}
