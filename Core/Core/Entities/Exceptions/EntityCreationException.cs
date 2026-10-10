using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Exceptions
{
    public class EntityCreationException<T> : Exception
    {
        public EntityCreationException(string message)
        : base($"Error creating an instance of {typeof(T).Name}." + message)
        { 
        }
    }
}
