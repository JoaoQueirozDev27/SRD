using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Exceptions
{
    public class CreatingRequestException : Exception
    {
        public CreatingRequestException(string message) : base("Error creating the request. Content error =>" + message) { }
    }
}
