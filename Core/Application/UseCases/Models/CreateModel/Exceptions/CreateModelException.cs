using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Models.CreateModel.Exceptions
{
    public class CreateModelException : Exception
    {
        public CreateModelException(string message) : base("An error occurred while creating the model." + message) { }
    }
}
