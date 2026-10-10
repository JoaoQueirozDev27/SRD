using Domain.Entities.Rules;
using Domain.Entities;
using Domain.value_objects;
using Domain.Enums;
using System;

namespace TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            RuleRelationalOperators rule = new RuleRelationalOperators(new Field[]
            {
                Field.Create(new IDInt(1),Name.Create("Parâmetro","1"),Value.Create("6")),
                Field.Create(new IDInt(2),Name.Create("Parâmetro","2"),Value.Create("6"))
            },
            ERuleRelationalOperators.Equals);

            Console.WriteLine(rule.Execute() ? "Igual" : "Diferente");                     
        }
    }
}
