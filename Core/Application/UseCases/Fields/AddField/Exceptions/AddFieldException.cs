using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Fields.AddField.Exceptions
{
    public class AddFieldException : Exception
    {
        public AddFieldException(string message) : base("Error adding field => " + message) { }
    }
}
