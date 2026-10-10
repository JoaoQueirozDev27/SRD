using Domain.Entities.Rules;
using Domain.Entities;

namespace API.DTOs.Rules
{
    public record RuleRelationalOperatorDTO
    {
        public string Operator { get; private set; }
        public int Value1 { get; private set; }
        public int Value2 { get; private set; }
    }
}
