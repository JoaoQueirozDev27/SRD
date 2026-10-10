using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Rules
{
    public record RuleRelationalOperators : Rule<bool>
    {
        private const int QtFields = 2;
        private ERuleRelationalOperators ERO { get; set; }
        public RuleRelationalOperators(Field[] fields,ERuleRelationalOperators ero) : base(QtFields)
        {
            if(fields.Length != QtFields)
                throw new ArgumentException($"The number of fields must be equal to {QtFields}.");

            for (int i = 0; i < QtFields; i++)
            {
                if (fields[i] == null)
                    throw new ArgumentNullException($"Field at index {i} cannot be null.");
                AddField(fields[i]);
            }

            ERO = ero;
        }
        public override bool Execute()
        {
            if (Fields.Count != QtFields)
                throw new InvalidOperationException($"The number of fields must be equal to {QtFields}.");

            if (!GetField(0).Value.intValue(out int v1))
                throw new FormatException("The value of the first field is not a valid integer.");

            if (!GetField(1).Value.intValue(out int v2))
                throw new FormatException("The value of the second field is not a valid integer.");

            return ERO switch
            {
                ERuleRelationalOperators.Less =>  v1 < v2,
                ERuleRelationalOperators.Greater => v1 > v2,
                ERuleRelationalOperators.LessOrEqual => v1 <= v2,
                ERuleRelationalOperators.GreaterOrEqual => v1 >= v2,
                ERuleRelationalOperators.Equals => v1 == v2,
                ERuleRelationalOperators.NotEquals => v1 != v2,
                _ => throw new ArgumentOutOfRangeException(nameof(ERO), ERO, null)
            };
        }
    }
}
