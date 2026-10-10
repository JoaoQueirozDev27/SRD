using Microsoft.AspNetCore.Mvc;
using Application.UseCases.Exceptions;
using Application.UseCases.Rules.ExecuteRule;
using Domain.Entities;
using Domain.value_objects;
using Domain.Enums;
using Domain.Entities.Rules;
using API.DTOs.Rules;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Rules/RelationalOperator")]
    public class RuleRelationalOperatorController : ControllerBase
    {
        [HttpPost("Execute")]
        public IActionResult Execute([FromBody] RuleRelationalOperatorDTO dto)
        {
            try
            {
                if (dto == null)
                    return BadRequest("Request body cannot be null.");

                if (!Enum.TryParse<ERuleRelationalOperators>(
                        dto.Operator,
                        true,
                        out var ruleOperator))
                {
                    return BadRequest(
                        $"Invalid operator: {dto.Operator}."
                    );
                }

                Field field1 = Field.Create(
                    new IDInt(1),
                    Name.Create("v1"),
                    Value.Create(dto.Value1.ToString())
                );

                Field field2 = Field.Create(
                    new IDInt(2),
                    Name.Create("v2"),
                    Value.Create(dto.Value2.ToString())
                );

                var rule = new RuleRelationalOperators(
                    new[] { field1, field2 },
                    ruleOperator
                );

                var request = new ExecuteRuleRequest<bool>(rule);

                var handler = new ExecuteRuleHandler<bool>(request);

                bool result = handler.Handle();

                return Ok(new
                {
                    result
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new
                {
                    error = ex.Message
                });
            }
            catch (FormatException ex)
            {
                return UnprocessableEntity(new
                {
                    error = ex.Message
                });
            }
            catch (InvalidOperationException ex)
            {
                return UnprocessableEntity(new
                {
                    error = ex.Message
                });
            }
        }
    }
}

