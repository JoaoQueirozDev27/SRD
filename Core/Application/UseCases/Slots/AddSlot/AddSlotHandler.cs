using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UseCases.Slots.AddSlot.Exceptions;

namespace Application.UseCases.Slots.AddSlot
{
    public class AddSlotHandler
    {
        private readonly AddSlotRequest _addSlotRequest;
        public AddSlotHandler(AddSlotRequest addSlotRequest)
        {
            _addSlotRequest = addSlotRequest;
        }
        public void Handle()
        {
            try
            {
                _addSlotRequest.Model.AddSlot(_addSlotRequest.Slot);
            }
            catch (Exception ex)
            {
                throw new AddSlotRequestException("An error occurred while adding the slot to the model: " + ex.Message);
            }
        }
    }
}
