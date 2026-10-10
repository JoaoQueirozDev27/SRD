using Application.UseCases.Rule.CreateRule.Exceptions.Application.UseCases.Rules.ExecuteRule.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Rules.ExecuteRule
{
    public class ExecuteRuleHandler<T>
    {
        private readonly ExecuteRuleRequest<T> _request;
        public ExecuteRuleHandler(ExecuteRuleRequest<T> request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            _request = request;
        }
        public T Handle()
        {
            try
            {
                return _request.Rule.Execute();
            }
            catch (Exception ex)
            {
                throw new ExecuteRuleException(ex.Message);
            }
        }

    }
}
