using Application.UseCases.Fields.AddField.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Fields.AddField
{
    public class AddFieldHandler
    {
        private readonly AddFieldRequest _addFieldRequest;
        public AddFieldHandler(AddFieldRequest addFieldRequest)
        {
            _addFieldRequest = addFieldRequest;
        }

        public void Handle()
        {
            try
            {
                var slot = _addFieldRequest.Slot;
                if (slot == null)
                {
                    throw new Exception($"Slot with ID {_addFieldRequest.Slot.ID.Id} not found in the model.");
                }
                slot.AddField(_addFieldRequest.Field);
            }
            catch (Exception ex)
            {
                throw new AddFieldException(ex.Message);
            }
        }
    }
}
