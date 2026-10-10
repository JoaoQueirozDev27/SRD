using Domain.Entities.Exceptions;
using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model
    {
        public IDInt ID { get; }
        public Name Name { get; }

        private readonly List<Slot> _slots = new();

        public IReadOnlyCollection<Slot> Slots =>
            _slots.ToArray();

        public Model(IDInt id, Name name)
        {   
            try
            {
                ArgumentNullException.ThrowIfNull(id);
                ArgumentNullException.ThrowIfNull(name);

                ID = id;
                Name = name;
            }
            catch (Exception ex)
            {
                throw new EntityCreationException<Model>(ex.Message);
            }
        }

        public void AddSlot(Slot slot)
        {
            ArgumentNullException.ThrowIfNull(slot);
            _slots.Add(slot);
        }

        public Slot GetSlot(IDInt id)
        {
            ArgumentNullException.ThrowIfNull(id);
            return _slots.First(x => x.ID.Id == id.Id);
        }
    }
}
