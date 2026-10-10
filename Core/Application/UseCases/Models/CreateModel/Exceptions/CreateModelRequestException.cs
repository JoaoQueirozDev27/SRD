using Application.UseCases.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Models.CreateModel.Exceptions
{
    public class CreateModelRequestException : CreatingRequestException
    {
        public CreateModelRequestException(string message)
        : base(message)
        {
        }
    }
}
