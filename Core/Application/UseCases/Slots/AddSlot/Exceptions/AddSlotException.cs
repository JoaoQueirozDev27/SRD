using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Slots.AddSlot.Exceptions
{
    public class AddSlotException : Exception
    {
        public AddSlotException(string message) : base("An error occurred while adding the slot." + message) { }
    }
}
