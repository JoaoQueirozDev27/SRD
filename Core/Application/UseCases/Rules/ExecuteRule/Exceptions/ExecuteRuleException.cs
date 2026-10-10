using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Rule.CreateRule.Exceptions
{
    namespace Application.UseCases.Rules.ExecuteRule.Exceptions
    {
        public class ExecuteRuleException : Exception
        {
            public ExecuteRuleException(string message)
                : base("Error executing the rule. Content error => " + message)
            {
            }
        }
    }
}
