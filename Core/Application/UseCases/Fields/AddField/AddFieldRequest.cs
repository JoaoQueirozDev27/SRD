using Domain.Entities;
using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UseCases.Exceptions;

namespace Application.UseCases.Fields.AddField
{
    public record AddFieldRequest
    {
        public Slot Slot { get; private set; }
        public Field Field  { get; private set; }

        private AddFieldRequest(Slot slot, Field field)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(slot);
                ArgumentNullException.ThrowIfNull(field);
                Field = field;
                Slot = slot;
            }
            catch (Exception ex)
            {
                throw new CreatingRequestException(ex.Message);
            }
        }
        public static AddFieldRequest Create(
            Slot Slot,
            Field field
        ) => new AddFieldRequest(Slot, field);

    }
}
