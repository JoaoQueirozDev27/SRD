using Domain.Entities;
using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UseCases.Slots.AddSlot.Exceptions;
using Application.UseCases.Exceptions;

namespace Application.UseCases.Slots.AddSlot
{
    public class AddSlotRequest
    {
        public Model Model { get; private set; }
        public Slot Slot { get; private set; }

        private AddSlotRequest(Model model, Name name, IDInt slotId)
        {
            try
            {
                Model = model;
                Slot = new Slot(slotId, name, model.ID);
            }
            catch (Exception ex)
            {
                throw new CreatingRequestException(ex.Message);
            }
        }

        private AddSlotRequest(Model model, Slot Slot)
        {
            if(model == null)
            {
                throw new AddSlotRequestException("Model cannot be null");
            }
            if(Slot == null)
            {
                throw new AddSlotRequestException("Slot cannot be null");
            }
            Model = model;
            this.Slot = Slot;
        }

        public static AddSlotRequest Create(
            Model model,
            Name name,
            IDInt slotId
        ) => new AddSlotRequest(model, name, slotId);

        public static AddSlotRequest Create(
            Model model, Slot Slot
        ) => new AddSlotRequest(model, Slot);

    }
}
