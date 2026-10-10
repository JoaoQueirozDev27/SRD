using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Rules;

namespace Application.UseCases.Rules.ExecuteRule
{
    public class ExecuteRuleRequest<T>
    {
        public Rule<T> Rule { get; }

        public ExecuteRuleRequest(Rule<T> rule)
        {
            Rule = rule ?? throw new ArgumentNullException(nameof(rule));
        }
    }
}
