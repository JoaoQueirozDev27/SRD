using Application.UseCases.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Slots.AddSlot.Exceptions
{
    public class AddSlotRequestException : CreatingRequestException
    {
        public AddSlotRequestException(string message) : base(message)
        {
        }
    }
}
